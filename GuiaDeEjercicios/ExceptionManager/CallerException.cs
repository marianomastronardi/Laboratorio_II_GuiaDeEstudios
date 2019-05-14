using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionManager
{
  public class CallerException
  {

    public void MiMetodoInstancia()
    {
      try
      {
        MathsExceptionClass m = new MathsExceptionClass(0);
      }
      catch (UnaException ue)
      {
        throw new MiException("From Una exception", ue);
      }
    }
  }

}
