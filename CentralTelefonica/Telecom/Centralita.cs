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

    public float GananciasPorLocal { get; }
    public float GananciasPorProvincial { get; }
    public float GananciasPorTotal { get; }
    public List<Llamada> Llamadas { get; }

    public Centralita()
    {

    }

    public Centralita(string nombreEmpresa) :this()
    {

    }

    public string Mostrar()
    {

    }

    public float CalcularGanancia(Llamada.TipoLlamada tipo)
    {

    }

    public void OrdenarLlamadas()
    {

    }
  }
}
