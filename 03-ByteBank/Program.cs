using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main()
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            Console.WriteLine(contaDaGabrielaCosta == contaDaGabriela);
            //Retorno: False
            Console.ReadLine();

            /* No C# temos dois tipos de variáveis: de valor e de referência
             * no caso das instanciações de objetos estamos comparando as referências do objeto na memória, ou seja, o endereço do objeto
             * por esse motivo o retorno da comparação é falso
             */

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabrielaCosta == contaDaGabriela);
            //Retorno: True
            Console.ReadLine();

            /* No caso acima estamos passando a referência de uma instância de objeto para outra instância, 
             * ou seja, agora ambos terão a mesma referência
             */
        }
    }
}
