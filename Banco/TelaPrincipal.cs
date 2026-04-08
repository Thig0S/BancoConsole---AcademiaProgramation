namespace Banco;

class TelaPrincipal
{
    public string? MostrarOpcoesMenu(ContaCorrente contaUm)
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
        return opcaoMenu;
    }
    public void OperacaoApresentarSaque(ContaCorrente contaUm)
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

    public void AcessarOperacaoDeposito(ContaCorrente contaUm)
    {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja depositar (R$): ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        contaUm.Depositar(valorDeposito);

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("O valor foi sacado com sucesso!");
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    internal void ApresentarOperacaoTransferencia(ContaCorrente contaUm, ContaCorrente contaDois)
    {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja transferir (R$): ");
        decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

        bool conseguiuTransferir = contaUm.TransferirPara(contaDois, valorTransferencia);

        if (!conseguiuTransferir)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Não foi possivel sacar o valor de R${valorTransferencia}!");
        }
        else
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"O valor de R${valorTransferencia} foi tranferido com sucesso!");
        }


        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    internal void AcessarTelaObterSaldo(ContaCorrente contaUm)
    {
        decimal saldo = contaUm.ObterSaldo();

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("O valor do saldo da conta é de (R$): " + saldo);
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }
}
