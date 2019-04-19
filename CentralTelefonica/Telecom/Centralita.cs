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

    public float GananciasPorLocal { get {return this.CalcularGanancia(Llamada.TipoLlamada.Local); } }
    public float GananciasPorProvincial { get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
    public float GananciasPorTotal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); } }
    public List<Llamada> Llamadas { get {return this.listaDeLlamdas; } }

    public Centralita()
    {
            this.listaDeLlamdas = new List<Llamada>();
    }

    public Centralita(string nombreEmpresa) :this()
    {
            this.razonSocial = nombreEmpresa;
    }

    public string Mostrar()
    {
            StringBuilder sb = new StringBuilder();

            sb.Append("Razon Social: " + this.razonSocial + "\n");
            sb.Append("Ganancia Local: " + this.GananciasPorLocal + "\n");
            sb.Append("Ganancia Provincial: " + this.GananciasPorProvincial + "\n");
            sb.Append("Ganancia Total: " + this.GananciasPorTotal + "\n");

            foreach(Llamada call in this.Llamadas)
            {
                sb.Append(call.Mostrar());
            }

            return sb.ToString();
        }

    private float CalcularGanancia(Llamada.TipoLlamada tipo)
    {
            float ganancia = 0;

            if(tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
            {
                
            }

            if(tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
            {

            }

            return ganancia;
    }

    public void OrdenarLlamadas()
    {

    }
  }
}
