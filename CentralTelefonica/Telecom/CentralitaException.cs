using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom
{
  public class CentralitaException : Exception
  {
    private string nombreclase;
    private string nombreMetodo;

    public string NombreClase { get { return this.nombreclase; } }
    public string NombreMetodo { get { return this.nombreMetodo; } }

    public CentralitaException(string mensaje, string clase, string metodo) :this(mensaje, clase, metodo, null)
    {
      
    }

    public CentralitaException(string mensaje, string clase, string metodo, Exception innerException) :base(mensaje, innerException)
    {
      this.nombreclase = clase;
      this.nombreMetodo = metodo;
    }
  }
}
