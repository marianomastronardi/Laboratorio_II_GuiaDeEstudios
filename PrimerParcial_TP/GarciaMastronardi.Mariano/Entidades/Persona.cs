using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
    private string apellido;
    private int dni;
    private int edad;
    private string nombre;

    public string Apellido { get { return this.apellido; } }
    public int Dni { get { return this.dni; } }
    public int Edad { get { return this.edad; } }
    public string Nombre { get { return this.nombre; } }

    public Persona(string nombre, string apellido, int edad, int dni)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.edad = edad;
      this.dni = dni;
    }

    public virtual string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("Apellido: " + this.Apellido + "\n");
      sb.Append("Dni: " + this.Dni + "\n");
      sb.Append("Edad: " + this.Edad + "\n");
      sb.Append("Nombre: " + this.nombre + "\n");

      return sb.ToString();
    }

    public abstract bool ValidarAptitud();
  }
}
