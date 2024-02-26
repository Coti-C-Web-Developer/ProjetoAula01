using ProjetoAula01.Entities;

namespace ProjetoAula01.Repositories
{
    public class ClienteRepository
    {

        //Método para gravar os dados de um cliente em arquivo
        public void ExportarDados(Cliente cliente)
        {
            var writer = new StreamWriter("c:\\temp\\clientes.txt", true);
            writer.WriteLine("\nCLIENTE:");
            writer.WriteLine(cliente.Id);
            writer.WriteLine(cliente.Nome);
            writer.WriteLine(cliente.Cpf);
            writer.WriteLine(cliente.Email);
            writer.Close();
        }
    }
}
