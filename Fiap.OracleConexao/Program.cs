using Fiap.OracleConexao.Services;
using Fiap.OracleConexao.Models;

namespace Fiap.OracleConexao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- Bem-vindo ao Sistema de Consulta de Clientes Oracle-- - ");
            Console.WriteLine("Por favor, faça o login para continuar.");
            // --- Etapa 1: Solicitar Credenciais ---
            Console.Write("Usuário Oracle: ");
            string? usuario = Console.ReadLine(); // Lê o nome de usuário digitado
            Console.Write("Senha Oracle: ");
            string? senha = Console.ReadLine(); // Lê a senha digitada
                                                // Verifica se o usuário digitou algo (não deixou em branco)
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                Console.WriteLine("\nErro: Usuário e senha não podem estar em branco.");
                Console.WriteLine("Aplicação será encerrada.");
                return; // Encerra a aplicação
            }
        }
    }
}