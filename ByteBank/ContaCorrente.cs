public class ContaCorrente
{
    public string titular { get; set; }
    public int agencia { get; set; }
    public int numero { get; set; }
    public double saldo { get; set; }

    public bool Sacar(double valor)
    {
        if (saldo < valor)
        {
            return false;
        }
        else
        {
            saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public bool Tranferir(double valor, ContaCorrente contaDestino)
    {
        if (saldo < valor)
        {
            return false;
        }

        saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}