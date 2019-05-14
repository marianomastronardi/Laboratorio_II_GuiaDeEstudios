using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telecom;

namespace Test
{
  class Test
  {
    static void Main(string[] args)
    {
      try
      {
        // Mi central 
        Centralita c = new Centralita("Fede Center");

        // Mis 4 llamadas 
        Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
        Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
        Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
        Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

        // Las llamadas se irán registrando en la Centralita. 
        // La centralita mostrará por pantalla todas las llamadas según las vaya registrando. 
        //c.Llamadas.Add(l1);
        c = c + l1;
        Console.WriteLine(c.ToString());
        //c.Llamadas.Add(l2);
        c = c + l2;
        Console.WriteLine(c.ToString());
        //c.Llamadas.Add(l3);
        c = c + l3;
        Console.WriteLine(c.ToString());
        //c.Llamadas.Add(l4);
        c = c + l4;

        //prueba exception
        c = c + l4;

        Console.WriteLine(c.ToString());

        c.OrdenarLlamadas();
        Console.WriteLine(c.ToString());

      }
      catch (CentralitaException ce)
      {
        Console.WriteLine(ce.Message);
      }
      catch(Exception e)
      {
        Console.WriteLine(e.Message);
      }
      finally
      {
        Console.ReadKey();
      }
    }
  }
}
