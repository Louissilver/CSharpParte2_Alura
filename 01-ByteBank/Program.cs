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
            contaCorrente.saldo = 537.76;

            Console.WriteLine(contaCorrente.titular);
            Console.WriteLine(contaCorrente.agencia);
            Console.WriteLine(contaCorrente.numero);
            Console.WriteLine(contaCorrente.saldo);

            Console.ReadLine();
        }
    }
}
