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
                titular = marcos,
                agencia = 100,
                numero = 56526,
                saldo = 120.60
            };

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
                titular = gabriela
            };

            contaPaulo.Tranferir(100, contaDaGabriela);

            Console.WriteLine(contaMarcos.titular);
            Console.WriteLine(contaMarcos.saldo);
            Console.WriteLine(contaPaulo.titular);
            Console.WriteLine(contaPaulo.saldo);
            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine(contaDaGabriela.saldo);
        }
    }
}
