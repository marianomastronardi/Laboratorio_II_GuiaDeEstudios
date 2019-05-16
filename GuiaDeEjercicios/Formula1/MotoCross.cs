using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
  public class MotoCross : VehiculoDeCarrera
  {
    private short cilindrada;

    public short Cilindrada
    {
      get { return cilindrada; }
      set { cilindrada = value; }
    }

    public MotoCross(short numero, string escuderia) :base(numero, escuderia)
    {

    }

    public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
    {
      this.Cilindrada = cilindrada;
    }

    public override string MostrarDatos()
    {
      return base.MostrarDatos();
    }

    public static bool operator ==(MotoCross m1, MotoCross m2)
    {
      return (m1.Cilindrada == m2.Cilindrada);
    }

    public static bool operator !=(MotoCross m1, MotoCross m2)
    {
      return !(m1 == m2);
    }
  }
}
