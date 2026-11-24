using backUrbanPark.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace backUrbanPark.Repository
{
    public static class VagaRepository
    {
        /// <summary>
        /// Insere uma vaga no banco de dados.
        /// </summary>
        /// <param name="vaga"></param>
        /// <returns></returns>
        public static int Inserir(Vaga vaga)
        {
            return 1;
        }

        /// <summary>
        /// Busca uma vaga específica pelo ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Vaga? BuscarPorId(int id)
        {
            string sql = @"SELECT id_vaga, numero_vaga, tipo, status
                           FROM vagas
                           WHERE id_vaga = @Id";

            using (var cmd = new MySqlCommand(sql))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = Banco.ExecutarConsulta(cmd))
                {
                    if (reader.Read())
                    {
                        return MapearVaga(reader);
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Retorna todas as vagas cadastradas.
        /// </summary>
        /// <returns></returns>
        public static List<Vaga> ListarTodos()
        {
            string sql = @"SELECT id_vaga, numero_vaga, tipo, status
                           FROM vagas";

            List<Vaga> vagas = new List<Vaga>();

            using (var cmd = new MySqlCommand(sql))
            {
                using (var reader = Banco.ExecutarConsulta(cmd))
                {
                    while (reader.Read())
                    {
                        vagas.Add(MapearVaga(reader));
                    }
                }
            }

            return vagas;
        }

        /// <summary>
        /// Método auxiliar para converter uma linha do MySqlDataReader em um objeto Vaga.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static Vaga MapearVaga(MySqlDataReader reader)
        {
            int idVaga = reader.GetInt32("id_vaga");
            int numeroVaga = reader.GetInt32("numero_vaga");

            TipoVaga tipoVaga =
                Enum.Parse<TipoVaga>(reader.GetString("tipo"));

            TipoStatus tipoStatus =
                Enum.Parse<TipoStatus>(reader.GetString("status"));

            return new Vaga(
                idVaga,
                numeroVaga,
                tipoVaga,
                tipoStatus
            );
        }
    }
}