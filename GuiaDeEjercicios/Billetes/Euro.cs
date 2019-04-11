using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
  public class Euro
  {
    private static double cantidad;
    private static float cotizRespectoDolar = 1.13F;

    public Euro()
    {

    }

    public Euro(double cantidad) 
    {
      
    }

    public Euro(double cantidad, float cotizacion)
    {

    }

    public static explicit operator Dolar(Euro e)
    {
      return cotizRespectoDolar;
    }

    public static explicit operator Pesos(Euro e)
    {
      Pesos p = new Pesos();
      
    }

    public double GetCantidad()
    {
      return cantidad;
    }

    public static float GetCotizacion()
    {
      return cotizRespectoDolar;
    }

    public static implicit operator Euro(double d)
    {
      Euro euro = new Euro(d);
      return euro;
    }

    public static bool operator !=(Euro e, Dolar d)
    {

    }

    public static bool operator !=(Euro e, Pesos p)
    {

    }

    public static bool operator !=(Euro e1, Euro e2)
    {

    }

    public static Euro operator -(Euro e, Dolar d)
    {

    }

    public static Euro operator -(Dolar d, Pesos p)
    {

    }

    public static Euro operator +(Euro e, Dolar d)
    {

    }

    public static Euro operator +(Euro e, Pesos p)
    {

    }

    public static bool operator ==(Euro e, Dolar d)
    {

    }

    public static bool operator ==(Euro e, Pesos e)
    {

    }

    public static bool operator ==(Euro e1, Euro e2)
    {

    }
  }
}
