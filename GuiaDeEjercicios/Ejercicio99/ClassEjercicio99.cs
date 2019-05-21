using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baraja;

namespace Ejercicio99
{
  class ClassEjercicio99 
  {
    static void Main(string[] args)
    {
      Naipes<string> baraja = new Naipes<string>();

      baraja.Agregar("1 de Oro");
      baraja.Agregar("2 de Oro");
      baraja.Agregar("3 de Oro");
      baraja.Agregar("4 de Oro");
      baraja.Agregar("5 de Oro");
      baraja.Agregar("6 de Oro");

      while(baraja.MiBaraja.Count > 0)
      { 
        Console.WriteLine(baraja.Dar());
      }
      Console.Read();
    }
  }
}
