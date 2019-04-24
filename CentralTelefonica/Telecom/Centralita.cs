using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecom
{
  public class Centralita
  {
    private List<Llamada> listaDeLlamdas;
    protected string razonSocial;

    public float GananciasPorLocal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); } }
    public float GananciasPorProvincial { get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
    public float GananciasPorTotal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); } }
    public List<Llamada> Llamadas { get { return this.listaDeLlamdas; } }

    public Centralita()
    {
      this.listaDeLlamdas = new List<Llamada>();
    }

    public Centralita(string nombreEmpresa) : this()
    {
      this.razonSocial = nombreEmpresa;
    }

    private string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.Append("Razon Social: " + this.razonSocial + "\n");
      sb.Append("Ganancia Local: " + this.GananciasPorLocal + "\n");
      sb.Append("Ganancia Provincial: " + this.GananciasPorProvincial + "\n");
      sb.Append("Ganancia Total: " + this.GananciasPorTotal + "\n");

      foreach (Llamada call in this.Llamadas)
      {
        sb.Append(call is Local ? ((Local)call).ToString() : ((Provincial)call).ToString());
      }

      return sb.ToString();
    }

    public override string ToString()
    {
      return this.Mostrar();
    }

    private float CalcularGanancia(Llamada.TipoLlamada tipo)
    {
      float ganancia = 0;

      foreach (Llamada ll in this.Llamadas)
      {
        if (tipo == Llamada.TipoLlamada.Local)
        {
          if (ll is Local)
            ganancia += ((Local)ll).CostoLlamada;
        }
        else if (tipo == Llamada.TipoLlamada.Provincial)
        {
          if (ll is Provincial)
            ganancia += ((Provincial)ll).CostoLlamada;
        }
        else
        {
          //(tipo == Llamada.TipoLlamada.Todas)
          if (ll is Local)
            ganancia += ((Local)ll).CostoLlamada;
          else
            ganancia += ((Provincial)ll).CostoLlamada;
        }
      }
      return ganancia;
    }

    public void OrdenarLlamadas()
    {

    }
  }
}
