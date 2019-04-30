using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Equipo
  {
    private const int cantiadadMaximaJugadores = 6;
    private List<Jugador> jugadores;
    private DirectorTecnico directorTecnico;
    private string nombre;

    public string Nombre
    {
      get { return this.nombre; }
      //set { this.nombre = value; }
    }


    public DirectorTecnico DirectorTecnico
    {
      //get { return directorTecnico; }
      set {  this.directorTecnico = value.ValidarAptitud() ? value : null ; }
    }

    private Equipo()
    {
      this.jugadores = new List<Jugador>();
    }

    public Equipo(string nombre) : this()
    {
      this.nombre = nombre;
    }

    public static explicit operator string(Equipo e)
    {
      StringBuilder sb = new StringBuilder();
      //Datos Equipo
      sb.Append("Nombre: " + e.Nombre);

      //DT
      sb.Append(e.directorTecnico == null ? "Sin DT asignado" : e.directorTecnico.Mostrar());

      //Jugadores
      if(e.jugadores != null)
      {
        foreach(Jugador j in e.jugadores)
        {
          sb.Append(j.Mostrar());
        }
      }

      return sb.ToString();
    }

    public static bool operator !=(Equipo e, Jugador j)
    {
      return e.jugadores.Contains(j);
    }

    public static bool operator ==(Equipo e, Jugador j)
    {
      return e.jugadores.Contains(j);
    }

    public static Equipo operator +(Equipo e, Jugador j)
    {
      if (e != j && e.jugadores.Count() < cantiadadMaximaJugadores && j.ValidarAptitud())
        e.jugadores.Add(j);
      return e;
    }

    public static bool ValidarEquipo(Equipo e)
    {
      return (e.directorTecnico != null && e.jugadores.Any(a => a.Posicion == Posicion.Arquero) && e.jugadores.Any(def => def.Posicion == Posicion.Defensor) && e.jugadores.Any(c => c.Posicion == Posicion.Central) && e.jugadores.Any(del => del.Posicion == Posicion.Delantero) && e.jugadores.Count(j => j.Posicion == Posicion.Arquero) == 1 && e.jugadores.Count() == cantiadadMaximaJugadores);
    }
  }
}
