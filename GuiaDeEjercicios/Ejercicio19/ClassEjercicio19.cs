using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
  class ClassEjercicio19
  {
    static void Main(string[] args)
    {
      Sumador sumador = new Sumador();

      Console.WriteLine(sumador.Sumar(1, 2));
      Console.WriteLine( sumador.Sumar("1", "2"));

      Console.ReadKey();
    }
  }
}
