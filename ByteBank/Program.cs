using System;

namespace ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      ContaCorrente contaMarcos = new ContaCorrente();

      contaMarcos.titular = "Marcos";
      contaMarcos.agencia = 100;
      contaMarcos.numero = 56526;
      contaMarcos.saldo = 120.60;

      Console.WriteLine(contaMarcos.titular);
      Console.WriteLine(contaMarcos.saldo);
    }
  }
}
