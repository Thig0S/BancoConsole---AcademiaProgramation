using System.Security.Cryptography;

namespace Banco;

class Program
{
    static void Main(string[] args)
    {
        // Conta Corrente 1
        ContaCorrente contaUm = new ContaCorrente();
        contaUm.numeroIdentificacao = 1;
        contaUm.titular = "Tiago";
        contaUm.saldo = 400;
        contaUm.limiteDebito = 1200;

        // Conta Corrente 2
        ContaCorrente contaDois = new ContaCorrente();
        contaDois.numeroIdentificacao = 2;
        contaDois.titular = "Rech";
        contaDois.saldo = 12000;
        contaDois.limiteDebito = 1200;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Conta Corrente #{contaUm.numeroIdentificacao} de {contaUm.titular}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1 - Saque");
            Console.WriteLine("2 - Depósito");
            Console.WriteLine("3 - Transferência");
            Console.WriteLine("4 - Consulta de Saldo");
            Console.WriteLine("S - Sair");
            Console.WriteLine("-------------------------------------");
            Console.Write("Digite uma opção válida: ");
            string? opcaoMenu = Console.ReadLine()?.ToUpper();

            if (opcaoMenu == "S")
                break;

            if (opcaoMenu == "1")
            {
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite o valor que deseja sacar (R$): ");
                decimal valorSaque = Convert.ToDecimal(Console.ReadLine());

                if (!contaUm.Sacar(valorSaque))
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("O valor do limite de débito foi ultrapassado!");
                }
                else
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("O valor foi sacado com sucesso!");
                }

                Console.WriteLine("-------------------------------------");
                Console.Write("Digite ENTER para continuar...");
                Console.ReadLine();

            }
            else if (opcaoMenu == "2")
            {
                contaUm.Depositar();
            }
            else if (opcaoMenu == "3")
            {
                contaUm.TransferirPara(contaDois);
            }
            else if (opcaoMenu == "4")
            {
                contaUm.ObterSaldo();
            }
        }
    }
}
