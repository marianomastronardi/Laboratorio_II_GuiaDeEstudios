using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionManager
{
  public class CompetenciaNoDisponibleException : Exception
  {
    private string nombreClase;
    private string nombreMetodo;

    public string NombreClase { get { return this.nombreClase; } }
    public string NombreMetodo { get { return this.nombreMetodo; } }

    public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null)
    {

    }

    public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
    {

    }

    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("Excepción en el método {0} de la clase {1}:", this.NombreMetodo, this.NombreClase);
      sb.AppendLine(this.Message);
      Exception aux = this.InnerException;
      while (aux != null)
      {
        sb.AppendFormat("{0}\t", this.Message);
        aux = aux.InnerException;
      }

      return base.ToString();
    }
  }
}
