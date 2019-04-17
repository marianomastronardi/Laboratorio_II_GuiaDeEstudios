using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AtencionAlCliente
{
  public class PuestoAtencion
  {
    public enum Puesto
    {
      Caja1,
      Caja2
    }

    private static int numeroActual;
    private Puesto puesto;

    public static int NumeroActual
    {
      get { numeroActual = numeroActual + 1; return numeroActual; }
    }

    private PuestoAtencion()
    {
      numeroActual = 0;
    }

    public PuestoAtencion(Puesto puesto)
    {
      this.puesto = puesto;
    }
    
    public bool Atender(Cliente cli)
    {
      Thread.Sleep(3000);
      return true;
    }
    
  }
}
