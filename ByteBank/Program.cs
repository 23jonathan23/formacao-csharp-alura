using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaMarcos = new ContaCorrente()
            {
                titular = "Marcos",
                agencia = 100,
                numero = 56526,
                saldo = 120.60
            };

            ContaCorrente contaPaulo = contaMarcos;

            contaPaulo.Sacar(50);
            contaPaulo.Depositar(500);

            Console.WriteLine(contaMarcos.titular);
            Console.WriteLine(contaMarcos.saldo);
            Console.WriteLine(contaPaulo.titular);
            Console.WriteLine(contaPaulo.saldo);
        }
    }
}
