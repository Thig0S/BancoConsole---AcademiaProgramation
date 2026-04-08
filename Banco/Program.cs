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
            TelaPrincipal telaPrincipal = new TelaPrincipal();

            string? opcaoMenu = telaPrincipal.MostrarOpcoesMenu(contaUm);

            if (opcaoMenu == "S")
                break;

            if (opcaoMenu == "1")
                telaPrincipal.OperacaoApresentarSaque(contaUm);

            else if (opcaoMenu == "2")
                telaPrincipal.AcessarOperacaoDeposito(contaUm);

            else if (opcaoMenu == "3")
                telaPrincipal.ApresentarOperacaoTransferencia(contaUm, contaDois);

            else if (opcaoMenu == "4")
                telaPrincipal.AcessarTelaObterSaldo(contaUm);
        }
    }
}
