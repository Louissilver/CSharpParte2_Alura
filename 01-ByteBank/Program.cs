using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main()
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.titular = "Gabriela";
            contaCorrente.agencia = 863;
            contaCorrente.numero = 15;
            contaCorrente.saldo = 300;

            Console.WriteLine("Conta corrente da Gabriela e valores dos atributos:");
            Console.WriteLine("Titular: " + contaCorrente.titular);
            Console.WriteLine("Agência: " + contaCorrente.agencia);
            Console.WriteLine("Número: " + contaCorrente.numero);
            Console.WriteLine("Saldo: " + contaCorrente.saldo + "\n\n");

            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";

            Console.WriteLine("Conta corrente do Bruno com exibição de saldo antes e depois do saque:");
            Console.WriteLine(contaDoBruno.titular);
            Console.WriteLine("Saldo anterior: " + contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(50);
            Console.WriteLine("Resultado do saque: " + resultadoSaque);
            Console.WriteLine("Saldo posterior: " + contaDoBruno.saldo);
            Console.ReadLine();

        }
    }
}
