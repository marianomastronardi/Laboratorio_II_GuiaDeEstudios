using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia
{
    public class Torneo<T> where T : Equipo
    {
    private List<T> equipos;
    private string nombre;

    public string JugarPartido()
    {
      Random rnd = new Random(DateTime.Now.Millisecond);
      T e1 = this.equipos[rnd.Next(0, this.equipos.Count - 1)];
      T e2 = this.equipos[rnd.Next(0, this.equipos.Count - 1)];

      return this.CalcularPartido(e1, e2);
    }

    public static bool operator ==(Torneo<T> t, T e)
    {
      return t.equipos.Contains(e);
    }

    public static bool operator !=(Torneo<T> t, T e)
    {
      return !(t == e);
    }

    public static Torneo<T> operator +(Torneo<T> t, T e)
    {
      if (t != e)
      {
        t.equipos.Add(e);
      }

      return t;
    }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(this.nombre);

      foreach(T e in this.equipos)
      {
        sb.AppendLine(e.Ficha());
      }

      return sb.ToString();
    }

    private string CalcularPartido(T t1, T t2)
    {
      Random rand = new Random();

      return t1.Nombre + " " + ((t1 is EquipoDeFutbol) ? rand.Next(0, 5) : rand.Next(0, 100)) + " " + t2.Nombre + " " + ((t2 is EquipoDeFutbol) ? rand.Next(0, 5) : rand.Next(0, 100));
    }
  }
}
