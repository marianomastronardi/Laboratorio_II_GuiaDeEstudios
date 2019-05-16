using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
  public class VehiculoDeCarrera
  {
    private short cantidadCombustible;
    private bool enCompetencia;
    private string escuderia;
    private short numero;
    private short vueltasRestantes;

    public short VueltasRestantes
    {
      get { return vueltasRestantes; }
      set { vueltasRestantes = value; }
    }

    public short Numero
    {
      get { return this.numero; }
      set { this.numero = value; }
    }

    public string Escuderia
    {
      get { return escuderia; }
      set { escuderia = value; }
    }

    public bool EnCompetencia 
    {
      get { return this.enCompetencia; }
      set { this.enCompetencia = value; }
    }


    public short CantidadCombustible
    {
      get { return cantidadCombustible; }
      set { cantidadCombustible = value; }
    }

    public VehiculoDeCarrera(short numero, string escuderia)
    {
      this.Numero = numero;
      this.Escuderia = escuderia;
    }

    public virtual string MostrarDatos()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("Numero: {0}", this.Numero);
      sb.AppendFormat("Escuderia: {0}", this.Escuderia);

      return sb.ToString();
    }

    public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
    {
      return !(v1 == v2);
    }

    public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
    {
      return (v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia);
    }

  }
}
