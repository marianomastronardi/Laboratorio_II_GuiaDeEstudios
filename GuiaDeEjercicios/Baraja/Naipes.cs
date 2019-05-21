using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baraja
{
  public class Naipes<T> 
  {
    private List<T> miBaraja;

    public List<T> MiBaraja { get { return this.miBaraja; } }

    public Naipes()
    {
      this.miBaraja = new List<T>();
    }

    public void Agregar(T t)
    {
      this.miBaraja.Add(t);
    }

    public T Dar()
    {
      Random rand = new Random();
      int item = rand.Next(0, this.miBaraja.Count - 1);
      T carta = this.miBaraja[item];
      this.miBaraja.RemoveAt(item);
      return carta;
    }
  }
}
