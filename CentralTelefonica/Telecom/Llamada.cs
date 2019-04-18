using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom
{
    public class Llamada
    {

    public enum TipoLlamada
    {
      Local,
      Provincial,
      Todas
    }

    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;

    public float Duracion { get { return this.duracion; } }
    public string NroDestino { get { return this.nroDestino; } }
    public string NroOrigen { get { return this.nroOrigen; } }

    public Llamada(float duracion, string nroDestino, string nroOrigen)
    {

    }

    public string Mostrar()
    {

    }

    public static int OrdenarPorDuracion(Llamada llmadda1, Llamada llamada2)
    {
      //1 l1 > l2
    }
  }
}
