using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Club;

namespace Ejercicio29
{
  class ClassEjercicio29
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 29";

      Jugador j1 = new Jugador(28057192, "mariano", 5, 4);
      Jugador j2 = new Jugador(44052331, "valentin", 8, 3);

      Equipo e1 = new Equipo(11, "Barcelona");

      //JUGADOR
      Console.WriteLine("************************");
      Console.WriteLine("********JUGADOR*********");
      Console.WriteLine("************************");

      //GetPromedioGoles
      //Ejercicio 29
      //Console.WriteLine("getprom j1: " + j1.GetPromedioGoles());
      //Console.WriteLine("getprom j2: " + j2.GetPromedioGoles());
      //Ejercicio 31
      Console.WriteLine("getprom j1: " + j1.PromedioGoles);
      Console.WriteLine("getprom j2: " + j2.PromedioGoles);

      //MostrarDatos
      Console.WriteLine("mostrardatos j1: " + j1.MostrarDatos());
      Console.WriteLine("mostrardatos j2: " + j2.MostrarDatos());

      //==
      if (j1 == j2)
        Console.WriteLine("j1 == j2");
      else
        Console.WriteLine("j1 != j2");

      //EQUIPO
      Console.WriteLine("************************");
      Console.WriteLine("*********EQUIPO*********");
      Console.WriteLine("************************");

      //public static bool operator +(Equipo e, Jugador j)
      //agrego jugador 1
      if (e1 + j1)
        Console.WriteLine("agrego j1");

      //agrego jugador 2
      if (e1 + j2)
        Console.WriteLine("agrego j2");

      Console.ReadKey();
    }
  }
}
