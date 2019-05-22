using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contables
{
  public class Contabilidad<T, U>
    where T : Documento
    where U : Documento, new()
  {
    private List<T> egresos;
    private List<U> ingresos;

    public Contabilidad()
    {
      this.egresos = new List<T>();
      this.ingresos = new List<U>();
    }

    public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T e)
    {
      c.egresos.Add(e);
      return c;
    }

    public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U i)
    {
      c.ingresos.Add(i);
      return c;
    }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      foreach (T t in this.egresos)
      {
        sb.AppendLine(t.Numero.ToString());
      }

      foreach (U u in this.ingresos)
      {
        sb.AppendLine(u.Numero.ToString());
      }
      return sb.ToString();
    }
  }
}
