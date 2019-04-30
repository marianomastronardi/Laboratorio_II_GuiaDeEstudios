using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class DirectorTecnico : Persona
  {
    private int añosExperiencia;

    public int AñosExperiencia { get { return this.añosExperiencia; } set { this.añosExperiencia = value; } }

    public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) :base(nombre, apellido, edad, dni)
    {
      this.AñosExperiencia = añosExperiencia;
    }

    public virtual string Mostrar()
    {
      StringBuilder sb = new StringBuilder(base.Mostrar());
      sb.Append("Años Experiencia: " + this.AñosExperiencia);
      return sb.ToString();
    }

    public override bool ValidarAptitud()
    {
      return (this.Edad < 65 && this.AñosExperiencia >= 2);
    }
  }
}
