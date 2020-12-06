namespace ByteBank.Domain
{
    public class ContaCorrente
    {
        public Cliente titular { get; set; }
        public int agencia { get; set; }
        public int numero { get; set; }
        private double _saldo;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo += value;
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Tranferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}