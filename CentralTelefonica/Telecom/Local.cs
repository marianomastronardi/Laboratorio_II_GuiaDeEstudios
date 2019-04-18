using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom
{
  public class Local : Llamada
  {
    protected float costo;

    public float CostoLlamada { get { return this.CalcularCosto(); } }

    public Local(Llamada llamada, float costo)
    {

    }

    public Local(string origen, float duracion, string destino, float costo)
    {

    }

    public string Mostrar()
    {

    }

    private float CalcularCosto()
    {
      return (float)this.duracion * this.costo;
    }
  }
}
