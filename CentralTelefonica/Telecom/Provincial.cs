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

    public override float CostoLlamada { get { return this.CalcularCosto(); } }

    public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
    {
      this.franjaHoraria = miFranja;
    }

    public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
    {
      this.franjaHoraria = miFranja;
    }

    public override bool Equals(object obj)
    {
      return (this.GetType() == obj.GetType());
    }

    public override string ToString()
    {
      return this.Mostrar();
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

    protected string Mostrar()
    {
      StringBuilder sb = new StringBuilder(base.Mostrar());

      sb.Append("Franja Horaria: " + this.franjaHoraria + "\n");
      sb.Append("Costo Llamada: " + this.CostoLlamada + "\n");

      return sb.ToString();
    }
  }
}
