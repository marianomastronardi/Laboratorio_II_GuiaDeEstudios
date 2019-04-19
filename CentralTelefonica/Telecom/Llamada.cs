using System.Text;

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
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Duracion: " + this.duracion + "\n");
            sb.Append("Nro Origen: " + this.nroOrigen + "\n");
            sb.Append("Nro Destino: " + this.nroDestino + "\n");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            //1 l1 > l2
            return (llamada1.duracion > llamada2.duracion ? 1 : llamada1.duracion == llamada2.duracion ? 0 : -1);
        }
    }
}
