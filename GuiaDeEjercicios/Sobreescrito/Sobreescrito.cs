using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescritura
{
  public abstract class Sobreescrito
  {
    protected string miAtributo;

    public abstract string MiPropiedad { get; } 

    public Sobreescrito()
    {
      this.miAtributo = "Probar abstractos";
    }

    public override string ToString()
    {
      return "¡Este es mi método ToString sobreescrito!";
    }
    
    public override bool Equals(object obj)
    {
      return (this == obj);
    }

    public override int GetHashCode()
    {
      return 1142510187;
    }

    public abstract string MiMetodo();

  }
}
