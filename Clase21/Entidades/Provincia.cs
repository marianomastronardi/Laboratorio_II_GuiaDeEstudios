using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
    private int id;
    private string nombre;

    public string Nombre
    {
      get { return nombre; }
      set { nombre = value; }
    }

    public int ID
    {
      get { return id; }
      set { id = value; }
    }

    public Provincia(int id, string nombre)
    {
      this.ID = id;
      this.Nombre = nombre;
    }

    public override string ToString()
    {
      return this.Nombre;
    }
  }
}
