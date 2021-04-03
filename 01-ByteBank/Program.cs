using System;

namespace ByteBank
{
    class Program
    {
        static void Main()
        {
            Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora C#";
            gabriela.cpf = "434.562.878-20";

            Cliente bruno = new Cliente();
            bruno.nome = "Bruno";
            bruno.profissao = "Desenvolvedor Front-end";
            bruno.cpf = "124.592.844-20";

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = gabriela;
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 15;
            contaDaGabriela.saldo = 1000;

            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = bruno;
            contaDoBruno.agencia = 863;
            contaDoBruno.numero = 20;
            contaDoBruno.saldo = 500;


            Console.WriteLine($@"Conta corrente da Gabriela e valores dos atributos:
            Titular: {contaDaGabriela.titular.nome}
            Agência: {contaDaGabriela.agencia}
            Número: {contaDaGabriela.numero}
            Saldo: {contaDaGabriela.saldo}
            ");

            Console.WriteLine("*******************************************************************\n\n");

            Console.WriteLine($@"Conta corrente da Gabriela e valores dos atributos:
            Titular: {contaDoBruno.titular.nome}
            Agência: {contaDoBruno.agencia}
            Número: {contaDoBruno.numero}
            Saldo: {contaDoBruno.saldo}
            ");

            Console.WriteLine("*******************************************************************\n\n");

            double valorSaque = 50;

            Console.WriteLine("Conta corrente do Bruno com exibição de saldo antes e depois do saque:");
            Console.WriteLine("Saldo anterior: " + contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(valorSaque);
            Console.WriteLine("Resultado do saque: " + resultadoSaque);
            Console.WriteLine("Saldo posterior: " + contaDoBruno.saldo + "\n\n");

            Console.WriteLine("*******************************************************************\n\n");
            
            double valorDeposito = 250;

            Console.WriteLine("Conta corrente do Bruno com exibição de saldo antes e depois do depósito:");
            Console.WriteLine("Saldo anterior: " + contaDoBruno.saldo);
            contaDoBruno.Depositar(valorDeposito);
            Console.WriteLine("Valor de depósito: " + valorDeposito);
            Console.WriteLine("Saldo posterior: " + contaDoBruno.saldo + "\n\n");

            Console.WriteLine("*******************************************************************\n\n");

            double valorTransferencia = 20;

            Console.WriteLine("Saldo inicial da conta da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo inicial da conta do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Valor de transferência: " + valorTransferencia);
            bool resultadoTransferencia = contaDoBruno.Transferir(valorTransferencia, contaDaGabriela);
            Console.WriteLine("Resultado transferência: " + resultadoTransferencia);
            Console.WriteLine("Saldo final da conta da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo final da conta do Bruno: " + contaDoBruno.saldo);

            Console.ReadLine();
        }
    }
}
