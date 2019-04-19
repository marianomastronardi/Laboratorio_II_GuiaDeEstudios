using System.Text;

namespace Telecom
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public float CostoLlamada { get; }

        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float ret = 0;

            switch ((int)this.franjaHoraria)
            {
                case (int)Franja.Franja_1:
                    ret = 0.99F * this.duracion;
                    break;
                case (int)Franja.Franja_2:
                    ret = 1.25F * this.duracion;
                    break;
                case (int)Franja.Franja_3:
                    ret = 0.66F * this.duracion;
                    break;
                default:
                    break;
            }

            return ret;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append("Costo Llamada: " + this.CostoLlamada + "\n");
            sb.Append("Franja Horaria: " + this.franjaHoraria + "\n");

            return sb.ToString();
        }
    }
}
