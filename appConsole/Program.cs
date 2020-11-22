using System;

namespace appConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      int teste = 17;
      string mensagem = $@"Testestando template string do C# {@teste}";

      bool acompanhado = 17 == 17;

      if (teste >= 17 && acompanhado)
      {
        Console.WriteLine("João não é legal!");
      }

      Console.WriteLine(mensagem);

      switch (teste)
      {
        case 17:
          Console.WriteLine("Switch case 17");
          break;
        case 18:
          break;
        default:
          Console.WriteLine("teste");
          break;
      }

      int contador = 1;

      while (contador < 12)
      {
        Console.WriteLine(2 * contador);
        contador++;
      }

      for (int i = 0; i < 10; i++)
      {
        for (int f = 0; f <= i; f++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }

      int fatorial = 1;
      for (int i = 1; i < 11; i++)
      {
        fatorial *= i;
        Console.WriteLine(fatorial);
      }
    }
  }
}
