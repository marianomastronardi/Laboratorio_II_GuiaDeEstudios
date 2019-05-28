using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Persona
    {
    public string nombre;
    public string apellido;
    public string dni;
    private string nroTarjeta;
    
    public string DNI
    {
      get { return this.dni; }
      set { this.dni = value; }
    }


    public  string Apellido
    {
      get { return this.apellido; }
      set { this.apellido = value; }
    }

    public string Nombre
    {
      get { return this.nombre; }
      set { this.nombre = value; }
    }

    public Persona(string nombre, string apellido, string dni)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.dni = dni;
    }

    public static List<Persona> operator +(List<Persona> l, Persona p)
    {
      l.Add(p);
      return l;
    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("Nombre: {0}", this.Nombre);
      sb.AppendFormat(" Apellido: {0}", this.Apellido);
      sb.AppendFormat(" DNI: {0}", this.DNI);
      sb.AppendFormat(" Tarjeta: {0}", this.nroTarjeta);
      return sb.ToString();
    }

    public void SetTarjeta(string numero)
    {
      this.nroTarjeta = numero;
    }
  }
}
