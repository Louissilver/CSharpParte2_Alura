using ByteBank;

namespace ByteBank
{

    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        /// <summary>Método para realizar saque na conta.
        /// Métodos, por convenção, sempre são escritos no infinitivo e iniciam com letra maiúscula
        /// <para><see valor/> Valor a ser sacado.</para>
        /// </summary>
        public bool Sacar(double valor)
        {
            bool ehPossivelSacar = true;
            if (this.saldo > valor)
            {
                this.saldo -= valor;
                ehPossivelSacar = true;
            }
            return ehPossivelSacar;
        }

        /// <summary>Método para depósito saque na conta.
        /// <para><see valor/> Valor a ser depositado.</para>
        /// </summary>
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        /// <summary>Método para transferência de valores por contas.
        /// <para><see valor/> Valor a ser transferido via depósito.</para>
        /// </summary>
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            bool resultadoTransferencia = false;
            if (this.saldo > valor)
            {
                resultadoTransferencia = true;
                this.saldo -= valor;
                contaDestino.Depositar(valor);
            }
            return resultadoTransferencia;
        }
    }
}