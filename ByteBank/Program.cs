using System;
using ByteBank.Domain;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var marcos = new Cliente()
            {
                nome = "Marcos",
                cpf = "477.444",
                profissao = "Desenvolvedor"
            };

            ContaCorrente contaMarcos = new ContaCorrente()
            {
                Titular = marcos,
                Agencia = 100,
                Numero = 56526,
            };

            contaMarcos.Saldo = 120.60;

            ContaCorrente contaPaulo = contaMarcos;

            contaPaulo.Sacar(50);
            contaPaulo.Depositar(500);

            var gabriela = new Cliente()
            {
                nome = "Gabriela",
                cpf = "555.444",
                profissao = "Desenvolvedor SR"
            };

            ContaCorrente contaDaGabriela = new ContaCorrente()
            {
                Titular = gabriela
            };

            contaPaulo.Tranferir(100, contaDaGabriela);

            Console.WriteLine(contaMarcos.Titular);
            Console.WriteLine(contaMarcos.Saldo);
            Console.WriteLine(contaPaulo.Titular);
            Console.WriteLine(contaPaulo.Saldo);
            Console.WriteLine(contaDaGabriela.Titular);
            Console.WriteLine(contaDaGabriela.Saldo);
        }
    }
}
