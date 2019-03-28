using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
  public class Sumador
  {
    private int cantidadSumas;

    public Sumador(int cantidadSumas)
    {
      this.cantidadSumas = cantidadSumas;
    }

    public Sumador()
    {
      this.cantidadSumas = 0;
    }

    public long Sumar(long a, long b)
    {
      this.cantidadSumas++;
      return a + b;
    }

    public string Sumar(string a, string b)
    {
      this.cantidadSumas++;
      return a + b;
    }
  }
}
