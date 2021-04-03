using ByteBank;
using System;

namespace ByteBank
{

    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                this._saldo = value;
            }
        }



        /// <summary>Método para realizar saque na conta.
        /// Métodos, por convenção, sempre são escritos no infinitivo e iniciam com letra maiúscula
        /// <para><see valor/> Valor a ser sacado.</para>
        /// </summary>
        public bool Sacar(double valor)
        {
            bool ehPossivelSacar = true;
            if (this._saldo > valor)
            {
                this._saldo -= valor;
                ehPossivelSacar = true;
            }
            return ehPossivelSacar;
        }

        /// <summary>Método para depósito saque na conta.
        /// <para><see valor/> Valor a ser depositado.</para>
        /// </summary>
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        /// <summary>Método para transferência de valores por contas.
        /// <para><see valor/> Valor a ser transferido via depósito.</para>
        /// </summary>
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            bool resultadoTransferencia = false;
            if (this._saldo > valor)
            {
                resultadoTransferencia = true;
                this._saldo -= valor;
                contaDestino.Depositar(valor);
            }
            return resultadoTransferencia;
        }
    }
}