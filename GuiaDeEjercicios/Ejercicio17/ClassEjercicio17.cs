using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
  class ClassEjercicio17
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 17";

      Boligrafo bic = new Boligrafo(100, ConsoleColor.Blue);
      Boligrafo pen = new Boligrafo(50, ConsoleColor.Red);

      string resp = string.Empty;
      ConsoleColor colorOriginal = Console.ForegroundColor;

      Console.ForegroundColor = bic.Pintar(15, out resp) ? bic.color : colorOriginal;
      Console.WriteLine(resp);
      Console.ForegroundColor = bic.Pintar(15, out resp) ? bic.color : colorOriginal;
      Console.WriteLine(resp);
      Console.ForegroundColor = bic.Pintar(15, out resp) ? bic.color : colorOriginal;
      Console.WriteLine(resp);
      Console.ForegroundColor = bic.Pintar(15, out resp) ? bic.color : colorOriginal;
      Console.WriteLine(resp);
      Console.ForegroundColor = bic.Pintar(15, out resp) ? bic.color : colorOriginal;
      Console.WriteLine(resp);
      Console.ForegroundColor = bic.Pintar(15, out resp) ? bic.color : colorOriginal;
      Console.WriteLine(resp);
      Console.ForegroundColor = bic.Pintar(15, out resp) ? bic.color : colorOriginal;
      Console.WriteLine(resp);

      Console.ReadKey();
    }
  }
}
