using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club
{
  public class Equipo
  {
    private short cantidadDeJugadores;
    private List<Jugador> jugadores;
    private string nombre;

    private Equipo()
    {
      //this.nombre = string.Empty;
      //this.cantidadDeJugadores = 0;
      this.jugadores = new List<Jugador>();
    }

    public Equipo(short cantidad, string nombre) : this()
    {
      this.cantidadDeJugadores = cantidad;
      this.nombre = nombre;
    }

    public static bool operator +(Equipo e, Jugador j)
    {
      bool add = false;

      if (e.jugadores != null)
      {//si no existe el jugador
        if (!(e.jugadores.Contains(j)))
        {
          //no superar cantidadDeJugadores
          if (e.jugadores.Count() < e.cantidadDeJugadores)
          {
            e.jugadores.Add(j);
            add = true;
          }
        }
      }
      return add;
    }
  }
}
