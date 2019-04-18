using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio33
{
  class ClassEjercicio33
  {
    static void Main(string[] args)
    {
      Libro l = new Libro();
      string libroActual = "";
      int i = 0;

      //busco un indice inexistente
      Console.WriteLine(l[2]);

      //seteo un indice inexistente
      l[4] = "Libro 1";
      l[0] = "Libro 2";
      l[1] = "Libro 3";
      l[2] = "Libro 4";
      l[3] = "Libro 5";
      l[0] = "Libro 6";

      do { libroActual = l[i]; Console.WriteLine(libroActual); i++; } while (libroActual != "");

      Console.ReadKey();
    }
  }
}
