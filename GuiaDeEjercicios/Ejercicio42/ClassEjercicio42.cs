using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionManager;

namespace Ejercicio42
{
  class ClassEjercicio42
  {
    static void Main(string[] args)
    {
      CallerException caller = new CallerException();

      try
      {
        caller.MiMetodoInstancia();
      }
      catch (MiException me)
      {
        Exception aux = me;

        //busco los inner
        while(aux != null)
        {
          Console.WriteLine(aux.Message);
          aux = aux.InnerException;
        }
        Console.Read();
      }
    }
  }
}
