using System.Security.Cryptography;

namespace Banco;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string titular = "Thiago Goat";
            int numeroIdentificacao = RandomNumberGenerator.GetInt32(1, 1001);
            decimal limiteDebito = 1200;
            decimal saldo = 1000;

            System.Console.WriteLine("-------------------");
            System.Console.WriteLine($"Conta corrente de {titular}");
            System.Console.WriteLine("-------------------");

            System.Console.WriteLine("1 - Saque");
            System.Console.WriteLine("2 - Deposito");
            System.Console.WriteLine("3 - Consulta Saldo");
            System.Console.WriteLine("0 - Sair");
            System.Console.Write("Opcao: ");
            string? opcaoMenu = Console.ReadLine()?.ToLower();

            if (opcaoMenu == "0")
                break;

            switch (opcaoMenu)
            {
                case "1":
                    System.Console.Write("Digite o valor que deseja a sacar: R$");
                    decimal saque = Convert.ToDecimal(Console.ReadLine());

                    if (saldo <= limiteDebito)
                    {
                        System.Console.WriteLine("Valor de limite debito ultrapassado");
                        Console.ReadLine();
                    }
                    else
                    {
                        saldo -= saque;

                        System.Console.WriteLine("Valor sacado com sucesso!");
                        Console.ReadLine();
                    }
                    break;
                case "2":
                    System.Console.Write("Digite o valor que deseja a DEPOSITAR: R$");
                    decimal deposito = Convert.ToDecimal(Console.ReadLine());

                    if (deposito <= 0)
                    {
                        System.Console.WriteLine("Valor INVALIDO, digite valores acima de ZERO");
                        Console.ReadLine();
                        continue;
                    }
                    saldo += deposito;
                    System.Console.WriteLine("Valor Depositado com sucesso!");
                    Console.ReadLine();
                    break;
                case "3":
                    System.Console.WriteLine($"Seu saldo é R${saldo}");
                    Console.ReadLine();
                    break;
                default:
                    System.Console.WriteLine("Digite um valor valido!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
