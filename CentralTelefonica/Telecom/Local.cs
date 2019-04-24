using System.Text;

namespace Telecom
{
  public class Local : Llamada
  {
    protected float costo;

    public override float CostoLlamada { get { return this.CalcularCosto(); } }

    public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
    {
      this.costo = costo;
    }

    public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
    {
      this.costo = costo;
    }

    public override bool Equals(object obj)
    {
      return obj is Local;
    }

    public override string ToString()
    {
      return this.Mostrar();
    }

    protected string Mostrar()
    {
      StringBuilder sb = new StringBuilder(base.Mostrar());
      sb.Append("Costo: " + this.CostoLlamada + "\n");

      return sb.ToString();
    }

    private float CalcularCosto()
    {
      return (float)this.duracion * this.costo;
    }
  }
}
