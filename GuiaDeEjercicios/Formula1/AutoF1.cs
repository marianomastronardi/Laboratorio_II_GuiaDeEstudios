using System.Text;

namespace Formula1
{
  public class AutoF1 : VehiculoDeCarrera
  {
    //private short cantidadCombustible;
    //private bool enCompetencia;
    //private string escuderia;
    //private short numero;
    //private short vueltasRestantes;
    private short caballosDeFuerza;

    public short CaballosDeFuerza
    {
      get { return caballosDeFuerza; }
      set { caballosDeFuerza = value; }
    }


    public AutoF1(short numero, string escuderia) : base(numero, escuderia)
    {
      //this.numero = numero;
      //this.escuderia = escuderia;
      //this.enCompetencia = false;
      //this.cantidadCombustible = 0;
      //this.vueltasRestantes = 0;
    }

    public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
    {
      //this.numero = numero;
      //this.escuderia = escuderia;
      //this.enCompetencia = false;
      //this.cantidadCombustible = 0;
      //this.vueltasRestantes = 0;
      this.CaballosDeFuerza = caballosDeFuerza;
    }

    public override string MostrarDatos()
    {
      StringBuilder sb = new StringBuilder();

      //sb.Append("Caantidad Combustible: " + this.cantidadCombustible + "\n");
      //sb.Append("En Competencia: " + this.enCompetencia + "\n");
      //sb.Append("Escuderia: " + this.escuderia + "\n");
      //sb.Append("Numero: " + this.numero + "\n");
      //sb.Append("Vueltas Restantes: " + this.vueltasRestantes + "\n");

      return sb.ToString();
    }

    public static bool operator !=(AutoF1 a1, AutoF1 a2)
    {
      return !(a1 == a2);
    }

    public static bool operator ==(AutoF1 a1, AutoF1 a2)
    {
      return (a1.CaballosDeFuerza == a2.CaballosDeFuerza); 
    }

    //getters
    //public short GetCantidadCombustible()
    //{
    //    return this.cantidadCombustible;
    //}

    //public bool GetEnCompetencia()
    //{
    //    return this.enCompetencia;
    //}

    //public short GetVueltasRestantes()
    //{
    //    return this.vueltasRestantes;
    //}

    //setters
    //public void SetCantidadCombustible(short cantidadCombustible)
    //{
    //    this.cantidadCombustible = cantidadCombustible;
    //}

    //public void SetEnCompetencia(bool enCompetencia)
    //{
    //    this.enCompetencia = enCompetencia;
    //}

    //public void SetVueltasRestantes(short vueltasRestantes)
    //{
    //    this.vueltasRestantes = vueltasRestantes;
    //}


  }
}
