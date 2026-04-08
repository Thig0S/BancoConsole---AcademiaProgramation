namespace Banco;

class ContaCorrente
{
    public int numeroIdentificacao;
    public string titular;
    public decimal saldo;
    public decimal limiteDebito;

    public bool Sacar(decimal valorSaque)
    {
        if (valorSaque > saldo + limiteDebito)
        {
            return false;
        }

        saldo -= valorSaque;
        return true;
    }

    public void Depositar()
    {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja depositar (R$): ");
        decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());

        saldo += valorDeposito;

        Console.WriteLine("-------------------------------------");
        Console.WriteLine("O valor foi sacado com sucesso!");
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    public void TransferirPara(ContaCorrente contaDestino)
    {
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite o valor que deseja transferir (R$): ");
        decimal valorTransferencia = Convert.ToDecimal(Console.ReadLine());

        saldo -= valorTransferencia;
        contaDestino.saldo += valorTransferencia;

        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"O valor de R${valorTransferencia} foi tranferido com sucesso!");
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    public void ObterSaldo()
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("O valor do saldo da conta é de (R$): " + saldo);
        Console.WriteLine("-------------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }
}
