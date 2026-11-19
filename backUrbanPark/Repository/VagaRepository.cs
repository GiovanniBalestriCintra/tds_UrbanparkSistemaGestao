using backUrbanPark.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace backUrbanPark.Repository
{
    internal class VagaRepository
    {
        /// <summary>
        /// Insere uma vaga no banco de dados.
        /// </summary>
        /// <param name="vaga"></param>
        /// <returns></returns>
        public int Inserir(Vaga vaga)
        {
            return 1;
        }

        /// <summary>
        /// Busca uma vaga específica pelo ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Vaga? BuscarPorId(int id)
        {
            string sql = "SELECT id_vaga, numero_vaga, vaga, status FROM vagas WHERE id = @Id";

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
        public List<Vaga> ListarTodos()
        {
            string sql = "SELECT id_vaga, numero_vaga, vaga, status FROM vagas";

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

            return null;

        }


        /// <summary>
        /// Método auxiliar para converter uma linha do MySqlDatReader em um objeto Vaga.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private Vaga MapearVaga(MySqlDataReader reader)
        {
            /// MAPEAMENTO DO RETORNO DO BANCO PARA OBJETO VAGA
            /// 

            int id_vaga = reader.GetInt32("id_Vaga");
            int numero_vaga = reader.GetInt32("numero_vaga");
            TipoVaga tipoVaga = Enum.Parse<TipoVaga>(reader.GetString("tipo"));
            TipoStatus tipoStatus = Enum.Parse<TipoStatus>(reader.GetString("status"));

            Vaga vagaBanco = new Vaga(id_vaga, numero_vaga, tipoVaga, tipoStatus);

            return new Vaga(id_vaga, numero_vaga, tipoVaga, tipoStatus);
        }




    } // Classe

} // Namespace
