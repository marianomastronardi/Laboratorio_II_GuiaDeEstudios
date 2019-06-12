using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio64
{
  public class Negocio
  {
    private Caja caja1;
    private Caja caja2;
    private List<string> clientes;

    public List<string> Clientes
    {
      get { return clientes; }
    }


    public Caja Caja2
    {
      get { return caja2; }
    }


    public Caja Caja1
    {
      get { return caja1; }
    }

    public Negocio(Caja c1, Caja c2)
    {
      this.clientes = new List<string>();
      this.caja1 = c1;
      this.caja2 = c2;
    }

    public void AsignarCaja()
    {
      Console.WriteLine("Asignando cajas...");

    }
  }
}
