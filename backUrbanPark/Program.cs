using backUrbanPark.Model;
using backUrbanPark.Repository;

namespace backUrbanPark
{
    internal class Program
    {
        static void Main(string[] args)
        {

            VagaRepository repository = new VagaRepository();

            List<Vaga> vagas = repository.ListarTodos();

            foreach (Vaga vag in vagas)
            {
                System.Console.WriteLine($"ID: {vag.Id} |\nTipo: {vag.Tipostatus} |\nVaga: {vag.TipoVaga}");
            }

        }
    }
}
