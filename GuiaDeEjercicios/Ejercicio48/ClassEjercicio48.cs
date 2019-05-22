using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contables;

namespace Ejercicio48
{
  class ClassEjercicio48
  {
    static void Main(string[] args)
    {
      Factura f1000 = new Factura(1000);
      Recibo r1000 = new Recibo(2000);
      Contabilidad<Documento, Recibo> cs = new Contabilidad<Documento, Recibo>();
      cs = cs + r1000;
      cs = cs + f1000;

      Console.WriteLine(cs.Mostrar());

      Console.Read();
    }
  }
}
