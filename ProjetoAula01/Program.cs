using ProjetoAula01.Entities;
using ProjetoAula01.Repositories;

namespace ProjetoAula01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nSISTEMA PARA CADASTRO DE CLIENTES\n");

            var cliente = new Cliente();

            cliente.Id = Guid.NewGuid();

            Console.Write("INFORME O NOME DO CLIENTE...: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("INFORME O CPF DO CLIENTE....: ");
            cliente.Cpf = Console.ReadLine();

            Console.Write("INFORME O EMAIL DO CLIENTE..: ");
            cliente.Email = Console.ReadLine();

            Console.WriteLine("\nDADOS DO CLIENTE:");
            Console.WriteLine("ID.......: " + cliente.Id);
            Console.WriteLine("NOME.....: " + cliente.Nome);
            Console.WriteLine("CPF......: " + cliente.Cpf);
            Console.WriteLine("EMAIL....: " + cliente.Email);

            var clienteRepository = new ClienteRepository();
            clienteRepository.ExportarDados(cliente);

            Console.ReadKey();
        }
    }
}
