using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formula1;

namespace Ejercicio30
{
  class ClassEjercicio30
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 30";

      bool canAdd = false;

      AutoF1 a1 = new AutoF1(1, "Ferrari");
      AutoF1 a2 = new AutoF1(2, "Mc Laren");
      AutoF1 a3 = new AutoF1(3, "Mercedes");
      AutoF1 a4 = new AutoF1(4, "Red Bull");

      Competencia c = new Competencia(31, 3, Competencia.TipoCompetencia.F1);

      try
      {
        //agrego competidores
        for (int i = 0; i < 4; i++)
        {
          canAdd = c + (i == 0 ? a1 : i == 1 ? a2 : i == 2 ? a3 : a4);
          Console.WriteLine(canAdd ? "Competidor " + (i + 1) : "No hay mas lugares");
        }

        //busco competidores
        for (int i = 0; i < 4; i++)
        {
          Console.WriteLine(c == (i == 0 ? a1 : i == 1 ? a2 : i == 2 ? a3 : a4) ? "Existe Competidor " + (i + 1) : "No existe el Competidor " + (i + 1));
        }

        //muestro los datos
        Console.WriteLine(c.MostrarDatos());

        Console.ReadKey();
      }
      catch (Exception ex)
      {
        StringBuilder sb = new StringBuilder();
        Exception aux = ex;
        while(aux != null)
        {
          sb.AppendLine(aux.Message);
          aux = aux.InnerException;
        }
        Console.WriteLine(sb.ToString());
        Console.Read();
      }

    }
  }
}
