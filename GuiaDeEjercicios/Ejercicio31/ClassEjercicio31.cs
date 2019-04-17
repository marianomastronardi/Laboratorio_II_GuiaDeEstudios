using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtencionAlCliente;

namespace Ejercicio31
{
  class ClassEjercicio31
  {
    static void Main(string[] args)
    {
      //Negocio
      Negocio fravega = new Negocio("Fravega");
      Negocio garbarino = new Negocio("Garbarino");

      //Cliente
      Cliente c1 = new Cliente(1, "Matias Gonzalez");
      Cliente c2 = new Cliente(2, "Ezequiel Gomez");
      Cliente c3 = new Cliente(3, "Juan Pichio");
      Cliente c4 = new Cliente(4, "Gas Cabral");
      Cliente c5 = new Cliente(5, "Lucas Tomaino");
      Cliente c6 = new Cliente(6, "Rudolf Serrano");

      fravega.Cliente = c1;
      fravega.Cliente = c3;
      fravega.Cliente = c5;

      garbarino.Cliente = c2;
      garbarino.Cliente = c4;
      garbarino.Cliente = c6;
      
      if (~fravega)Console.WriteLine("cliente 1 f");
      if(~garbarino)Console.WriteLine("cliente 1 g");
      if (~fravega) Console.WriteLine("cliente 2 f");
      if (~garbarino) Console.WriteLine("cliente 2 g");
      if (~fravega) Console.WriteLine("cliente 3 f");
      if (~garbarino) Console.WriteLine("cliente 3 g");

      Console.ReadKey();
    }
    
  }
}
