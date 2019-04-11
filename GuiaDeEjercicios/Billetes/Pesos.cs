using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
    private static double cantidad;
    private static float cotizRespectoDolar = 0.023F;
    
    private Pesos()
    {

    }

    public Pesos(double cantidad)
    {

    }

    public Pesos(double cantidad, float cotizacion)
    {

    }

    public static explicit operator Dolar(Pesos p)
    {

    }

    public static explicit operator Euro(Pesos e)
    {

    }

    public double GetCantidad()
    {
      return cantidad;
    }

    public static float GetCotizacion()
    {
      return cotizRespectoDolar;
    }

    private static implicit operator Pesos(double d)
    {

    }

    public static bool operator !=(Pesos p, Dolar d)
    {

    }

    public static bool operator !=(Pesos p, Euro e)
    {

    }

    public static bool operator !=(Pesos p1, Pesos p2)
    {

    }

    public static Pesos operator -(Pesos p, Dolar d)
    {

    }

    public static Pesos operator -(Pesos p, Euro e)
    {

    }

    public static Pesos operator +(Pesos p, Dolar d)
    {

    }

    public static Pesos operator +(Pesos p, Euro e)
    {

    }

    public static bool operator ==(Pesos p, Dolar d)
    {

    }

    public static bool operator ==(Pesos e, Euro e)
    {

    }

    public static bool operator ==(Pesos p1, Pesos p2)
    {

    }
  }
}
