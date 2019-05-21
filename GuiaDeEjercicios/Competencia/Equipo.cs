using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia
{
  public abstract class Equipo
  {
    private string nombre;
    private DateTime fechaCreacion;

    public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
    public DateTime FechaCreacion { get { return this.fechaCreacion; } set { this.fechaCreacion = value; } }

    public Equipo(string nombre, DateTime fecha)
    {
      this.Nombre = nombre;
      this.FechaCreacion = fecha;
    }

    public string Ficha()
    {
      return this.nombre + " fundado el " + this.fechaCreacion;
    }

  }
}
