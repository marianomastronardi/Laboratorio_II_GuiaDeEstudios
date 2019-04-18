using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club
{
  public class Jugador
  {
    private int dni;
    private string nombre;
    private int partidosJugados;
    //private float promedioGoles;
    private int totalGoles;

    public int Dni
    {
      get { return this.dni; }
      set { this.dni = value; }
    }

    public string Nombre
    {
      get { return this.nombre; }
      set { this.nombre = value; }
    }
    
    public int PartidosJugados
    {
      get { return this.partidosJugados; }
    }

    public float PromedioGoles
    {
      get { return (float)this.totalGoles / this.partidosJugados; }
    }

    public int TotalGoles
    {
      get { return this.totalGoles; }
    }

    private Jugador()
    {
      this.partidosJugados = 0;
     // this.promedioGoles = 0;
      this.totalGoles = 0;
    }

    public Jugador(int dni, string nombre) : this()
    {
      this.dni = dni;
      this.nombre = nombre;
    }

    public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
    {
      this.totalGoles = totalGoles;
      this.partidosJugados = totalPartidos;
    }

    //public float GetPromedioGoles()
    //{
    //  this.promedioGoles = (float)totalGoles / partidosJugados;
    //  return promedioGoles;
    //}

    public string MostrarDatos()
    {
      return "dni: " + this.dni + " nombre: " + this.nombre + " Partidos Jugados: " + this.partidosJugados + " Total Goles: " + this.totalGoles + " Promedio Goles: " + this.PromedioGoles;
    }

    public static bool operator !=(Jugador j1, Jugador j2)
    {
      return (j1.dni == j2.dni);
    }

    public static bool operator ==(Jugador j1, Jugador j2)
    {
      return (j1.dni == j2.dni);
    }

  }
}
