using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionManager
{
  public class MiException : Exception
  {
    public MiException(string mensaje, Exception innerException) : base(mensaje, innerException)
    {

    } 
  }
}
