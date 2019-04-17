using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
  public class Negocio
  {
    private PuestoAtencion caja;
    private Queue<Cliente> clientes;
    private string nombre;

    public Cliente Cliente
    {
      get
      {
        return clientes.Dequeue();
      }
      set
      {
        if (this.clientes != null)
        {
          if (!(this.clientes.Contains(value)))
            this.clientes.Enqueue(value);
        }

      }
    }

    public int ClientesPendientes
    {
      get { return clientes.Count(); }
    }

    private Negocio()
    {
      this.clientes = new Queue<Cliente>();
      this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
    }

    public Negocio(string nombre) : this()
    {
      this.nombre = nombre;
    }

    public static bool operator !=(Negocio n, Cliente c)
    {
      return n.clientes.Contains(c);
    }

    public static bool operator ==(Negocio n, Cliente c)
    {
      return n.clientes.Contains(c);
    }

    public static bool operator ~(Negocio n)
    {
      //El operador ~(Negocio) : bool generará una atención del próximo cliente en la cola,
      //utilizando la propiedad Cliente y el método Atender de PuestoAtencion. Retornará True si
      //pudo realizar la operación completa
      return n.caja.Atender(n.Cliente);
    }

    public static bool operator +(Negocio n, Cliente c)
    {
      bool existe = false;
      foreach (Cliente cn in n.clientes)
      {
        if (cn == c)
        {
          existe = true;
          break;
        }
      }
      return existe;
    }
  }
}

