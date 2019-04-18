using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
  public class Libro
  {
    private List<string> paginas;

    public string this[int i]
    {
      get { return (paginas == null) ? "Libro sin instanciar" : i > paginas.Count() - 1 ? "" : this.paginas[i]; }
      set
      {
        if(paginas == null)
        {
          paginas = new List<string>();
          paginas.Add(value);
        }
        else
        if (i > paginas.Count() - 1)
          paginas.Add(value);
        else
          this.paginas[i] = value;
      }
    }


  }
}
