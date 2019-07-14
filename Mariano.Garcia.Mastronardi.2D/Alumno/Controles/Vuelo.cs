using Entidades;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Controles
{
    [XmlInclude(typeof(IAvion))]
    public partial class Vuelo : UserControl, IAvion
    {
        private Avion avion;

        public EstadoVuelo Estado { get; }

        public void Despegar()
        {
            picAvion.Visible = true;
            this.avion.Despegar();
        }

        public void Estrellar()
        {
            
        }

        public Vuelo(int horasVuelo)
        {
            InitializeComponent();
            this.avion = new Avion(horasVuelo);
            this.avion.ReportarEstado += MoverAvion;

        }

        public int MoverAvion(int horasTotales, int horasRestantes)
        {
            if (this.picAvion.InvokeRequired)
            {
                var d = new ReporteDeEstado(MoverAvion);

                return (int)this.picAvion.Invoke(d, horasTotales, horasRestantes);
                
            }
            else
            {
                int porcentajeCompletado = 100 - (horasRestantes * 100) / horasTotales;
                // 664 es 100% entonces X es el porcentajeCompletado
                int ejeX = (664 * porcentajeCompletado) / 100;
                if (ejeX > 664)
                    ejeX = 664;

                this.picAvion.Location = new Point(ejeX + 58, this.picAvion.Location.Y);

                return porcentajeCompletado;
            }
        }
    }
}
