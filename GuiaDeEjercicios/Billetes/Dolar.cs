using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
  public class Dolar
  {
    private static double cantidad;
    private static float cotizRespectoDolar;

    public Dolar()
    {

    }

    public Dolar(double cantidad)
    {

    }

    public Dolar(double cantidad, float cotizacion)
    {

    }

    public static explicit operator Euro(Dolar d)
    {

    }

    public static explicit operator Pesos(Dolar d)
    {

    }

    public double GetCantidad()
    {

    }

    public static float GetCotizacion()
    {
      return float.MinValue;
    }

    public static implicit operator Dolar(double d)
    {
      Dolar dolar;
      return dolar;
    }

    public static bool operator !=(Dolar d, Euro e)
    {

    }

    public static bool operator !=(Dolar d, Pesos e)
    {

    }

    public static bool operator !=(Dolar d1, Dolar d2)
    {

    }

    public static Dolar operator -(Dolar d, Euro e)
    {

    }

    public static Dolar operator -(Dolar d, Pesos p)
    {

    }

    public static Dolar operator +(Dolar d, Euro e)
    {

    }

    public static Dolar operator +(Dolar d, Pesos p)
    {

    }

    public static bool operator ==(Dolar d, Euro e)
    {

    }

    public static bool operator ==(Dolar d, Pesos e)
    {

    }

    public static bool operator ==(Dolar d1, Dolar d2)
    {

    }
  }
}
