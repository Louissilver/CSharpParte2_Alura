using System;

namespace ByteBank
{
    class Program
    {
        static void Main()
        {
            Cliente gabriela = new Cliente();
            gabriela.Nome = "Gabriela";
            gabriela.Profissao = "Desenvolvedora C#";
            gabriela.Cpf = "434.562.878-20";

            Cliente bruno = new Cliente();
            bruno.Nome = "Bruno";
            bruno.Profissao = "Desenvolvedor Front-end";
            bruno.Cpf = "124.592.844-20";

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.Titular = gabriela;
            contaDaGabriela.Agencia = 863;
            contaDaGabriela.Numero = 15;
            contaDaGabriela.Saldo = 1000;

            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.Titular = bruno;
            contaDoBruno.Agencia = 863;
            contaDoBruno.Numero = 20;
            contaDoBruno.Saldo = 500;


            Console.WriteLine($@"Conta corrente da Gabriela e valores dos atributos:
            Titular: {contaDaGabriela.Titular.Nome}
            Agência: {contaDaGabriela.Agencia}
            Número: {contaDaGabriela.Numero}
            Saldo: {contaDaGabriela.Saldo}
            ");

            Console.WriteLine("*******************************************************************\n\n");

            Console.WriteLine($@"Conta corrente da Gabriela e valores dos atributos:
            Titular: {contaDoBruno.Titular.Nome}
            Agência: {contaDoBruno.Agencia}
            Número: {contaDoBruno.Numero}
            Saldo: {contaDoBruno.Saldo}
            ");

            Console.WriteLine("*******************************************************************\n\n");

            double valorSaque = 50;

            Console.WriteLine("Conta corrente do Bruno com exibição de saldo antes e depois do saque:");
            Console.WriteLine("Saldo anterior: " + contaDoBruno.Saldo);
            bool resultadoSaque = contaDoBruno.Sacar(valorSaque);
            Console.WriteLine("Resultado do saque: " + resultadoSaque);
            Console.WriteLine("Saldo posterior: " + contaDoBruno.Saldo + "\n\n");

            Console.WriteLine("*******************************************************************\n\n");
            
            double valorDeposito = 250;

            Console.WriteLine("Conta corrente do Bruno com exibição de saldo antes e depois do depósito:");
            Console.WriteLine("Saldo anterior: " + contaDoBruno.Saldo);
            contaDoBruno.Depositar(valorDeposito);
            Console.WriteLine("Valor de depósito: " + valorDeposito);
            Console.WriteLine("Saldo posterior: " + contaDoBruno.Saldo + "\n\n");

            Console.WriteLine("*******************************************************************\n\n");

            double valorTransferencia = 20;

            Console.WriteLine("Saldo inicial da conta da Gabriela: " + contaDaGabriela.Saldo);
            Console.WriteLine("Saldo inicial da conta do Bruno: " + contaDoBruno.Saldo);
            Console.WriteLine("Valor de transferência: " + valorTransferencia);
            bool resultadoTransferencia = contaDoBruno.Transferir(valorTransferencia, contaDaGabriela);
            Console.WriteLine("Resultado transferência: " + resultadoTransferencia);
            Console.WriteLine("Saldo final da conta da Gabriela: " + contaDaGabriela.Saldo);
            Console.WriteLine("Saldo final da conta do Bruno: " + contaDoBruno.Saldo);

            Console.ReadLine();
        }
    }
}
