using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio64
{
  public class Caja
  {
    private List<string> filaClientes;

    public List <string> FilaClientes
    {
      get { return filaClientes; }
      set { filaClientes = value; }
    }

    public Caja()
    {
      this.FilaClientes = new List<string>();
    }

    public void AtenderClientes()
    {
      foreach(string cliente in FilaClientes)
      {
        Console.WriteLine(cliente);
      }
    }
  }
}
