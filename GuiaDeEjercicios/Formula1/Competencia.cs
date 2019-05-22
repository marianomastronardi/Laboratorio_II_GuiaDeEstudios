using System.Collections.Generic;
using System.Text;
using ExceptionManager;


namespace Formula1
{
  public class Competencia<T> where T : VehiculoDeCarrera
  {
    public enum TipoCompetencia
    {
      F1,
      MotoCross
    }

    private short cantidadCompetidores;
    private short cantidadVueltas;
    private List<T> competidores;
    private TipoCompetencia tipo;

    public short CantidadCompetidores { get { return this.cantidadCompetidores; } set { this.cantidadCompetidores = value; } }
    public short CantidadVueltas { get { return this.cantidadVueltas; } set { this.cantidadVueltas = value; } }
    public VehiculoDeCarrera this[int i] { get {return this.competidores[i]; } }
    public TipoCompetencia Tipo
    {
      get { return tipo; }
      set { tipo = value; }
    }

    private Competencia()
    {
      this.competidores = new List<T>();
    }

    public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
    {
      this.CantidadVueltas = cantidadVueltas;
      this.CantidadCompetidores = cantidadCompetidores;
      this.Tipo = tipo;
    }

    public string MostrarDatos()
    {
      StringBuilder sb = new StringBuilder();

      sb.Append("Caantidad Competidores: " + this.cantidadCompetidores + "\n");
      sb.Append("Caantidad Vueltas: " + this.cantidadVueltas + "\n");
      foreach (T a in this.competidores)
      {
        sb.Append("    " + a.MostrarDatos() + "\n");
      }

      return sb.ToString();
    }

    public static bool operator +(Competencia<T> c, T a)
    {
      bool canAdd = false;
      try
      {
        if (!(c is null))
        {
          if (!(c.competidores is null))
          {
            if (c.competidores.Count < c.cantidadCompetidores)
            {
              if (!(c == a))
              {
                c.competidores.Add(a);
                //a.SetEnCompetencia(true);
                //a.SetVueltasRestantes(c.cantidadVueltas);
                //a.SetCantidadCombustible((short)new System.Random().Next(15, 100));
                canAdd = !canAdd;
              }
            }
          }
        }
      }
      catch (System.Exception e)
      {
        throw new System.Exception("Competencia incorrecta", e);
      }
  
      return canAdd;
    }

    public static bool operator -(Competencia<T> c, T a)
    {
      bool canOut = false;

      if (!(c is null))
      {
        if (!(c.competidores is null))
        {
          if (c.competidores.Contains(a))
          {
            c.competidores.Add(a);
            canOut = !canOut;
          }
        }
      }

      return canOut;
    }

    public static bool operator ==(Competencia<T> c, T v)
    {
      if((c.Tipo == TipoCompetencia.F1 && v is MotoCross) || (c.Tipo == TipoCompetencia.MotoCross && v is AutoF1))
        throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia", "==");

      return  c.competidores.Contains(v);
     }

    public static bool operator !=(Competencia<T> c, T v)
    {
      return !(c == v);
    }
  }
}
