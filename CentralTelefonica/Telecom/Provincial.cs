using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom
{
  public class Provincial : Llamada
  {
    public enum Franja
    {
      Franja_1,
      Franja_2,
      Franja_3
    }

    protected Franja franjaHoraria;

    public float CostoLlamada { get;  }

    public Provincial(Franja miFranja, Llamada llamada)
    {

    }

    public Provincial(string origen, Franja miFranja, float duracion, string destino)
    {

    }

    private float CalcularCosto()
    {
      float ret = 0;

      switch(this.franjaHoraria)
      {
        case (int)Franja.Franja_1:
          ret = 0.99F * this.duracion;
          break;
      
      }

    }
  }
}
