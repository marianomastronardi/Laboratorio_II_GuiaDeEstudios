using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
  class ClassEjercicio16
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 16";

      Alumno alumno1 = new Alumno("Perez", "Juan");
      //Alumno alumno1 = new Alumno();
      //alumno1.apellido = "Perez";
      //alumno1.nombre = "Juan";

      Alumno alumno2 = new Alumno("Gonzalez", "Matias");
      //Alumno alumno2 = new Alumno();
      //alumno2.apellido = "Gonzalez";
      //alumno2.nombre = "Matias";

      Alumno alumno3 = new Alumno("Gomez", "Ezequiel");

      Console.WriteLine(alumno1.Mostrar());
      Console.WriteLine(alumno2.Mostrar());
      Console.WriteLine(alumno3.Mostrar());

      //cambio colegio -- es static, por lo tanto le cambia la propiedad a todas las instancias del objeto
      Alumno.colegio = "UBA";

      Console.WriteLine(alumno1.Mostrar());
      Console.WriteLine(alumno2.Mostrar());
      Console.WriteLine(alumno3.Mostrar());

      //cambio colegio -- es static, por lo tanto le cambia la propiedad a todas las instancias del objeto
      Alumno.colegio = "UNQ";
      Console.WriteLine(alumno1.Mostrar());
      Console.WriteLine(alumno2.Mostrar());
      Console.WriteLine(alumno3.Mostrar());

      Console.ReadKey();
    }
  }
}
