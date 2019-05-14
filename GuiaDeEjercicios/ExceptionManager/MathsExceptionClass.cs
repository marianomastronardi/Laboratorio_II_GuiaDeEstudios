using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionManager
{
  public class MathsExceptionClass
  {
    public MathsExceptionClass()
    {
      DivideByZeroException();
    }

    public MathsExceptionClass(int nada)
    {
      try
      {
        new MathsExceptionClass();
      }
      catch (DivideByZeroException de)
      {
        throw new UnaException("lanzo desde Divide...", de);
      }
    }

    public static void DivideByZeroException()
    {
      throw new DivideByZeroException();
    }
  }
}
