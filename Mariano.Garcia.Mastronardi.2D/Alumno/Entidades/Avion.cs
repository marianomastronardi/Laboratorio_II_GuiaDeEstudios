using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate int ReporteDeEstado(int horasTotales, int horasRestantes);
    public enum EstadoVuelo
    {
        Programado,
        Volando,
        Aterrrizado
    }
    
    public class Avion : IAvion
    {
 
        private int horasVuelo;
        private Thread vuelo;

        public event ReporteDeEstado ReportarEstado;

        public EstadoVuelo Estado
        {
            get
            {
                 if (this.vuelo is null)
                     return  EstadoVuelo.Programado;
                   else
                   {
                    if (this.vuelo.IsAlive)
                        return EstadoVuelo.Volando;
                    else
                        return EstadoVuelo.Aterrrizado;
                    }
            }
        }
        public int HorasDeVuelo { get => this.horasVuelo; }

        public Avion(int horasVuelo)
        {
            this.horasVuelo = horasVuelo;
        }

        public void Despegar()
        {
            this.vuelo = new Thread(this.Volar);
            this.vuelo.Start();
        }

        public void Estrellar()
        {
            if(!(this.vuelo is null))
            {
                if (!(this.vuelo.IsAlive))
                    this.vuelo.Abort();
            }
        }

        public void Volar()
        {
            Thread.Sleep(1000);
            int horasRestantes = this.horasVuelo;
            int porcentajeCompletado = 100;
            
            while (porcentajeCompletado <= 100)
            {
                horasRestantes -= 1;
                porcentajeCompletado = this.ReportarEstado(this.horasVuelo, horasRestantes);
            }
        }
    }
}
