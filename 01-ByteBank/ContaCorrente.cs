public class ContaCorrente
{
    public string titular;
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
}