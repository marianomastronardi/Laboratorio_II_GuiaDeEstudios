using System;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar = 38.33F;
        //private float cotizRespectoDolar;

        public Pesos()
        {

        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion) : this(cantidad)
        {
            //   this.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad / Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            return new Euro((p.cantidad / Pesos.GetCotizacion()) / Euro.GetCotizacion());
        }

        public double GetCantidad()
        {
            return Math.Round(this.cantidad, 2);
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Pesos(double d)
        {
            return new Pesos(d);
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return ((p.cantidad / GetCotizacion()) == d.GetCantidad());
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return ((p.GetCantidad() / GetCotizacion()) == (e.GetCantidad() * Euro.GetCotizacion()));
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return (p1.cantidad == p2.cantidad);
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return (new Pesos(p.GetCantidad() - (d.GetCantidad() * GetCotizacion())));
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return (new Pesos(p.GetCantidad() - (e.GetCantidad() * Euro.GetCotizacion() * Pesos.GetCotizacion())));
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return (new Pesos(p.GetCantidad() + (d.GetCantidad() * GetCotizacion())));
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return (new Pesos(p.GetCantidad() + (e.GetCantidad() * Euro.GetCotizacion() * Pesos.GetCotizacion())));
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return ((p.cantidad / GetCotizacion()) == d.GetCantidad());
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return ((p.GetCantidad() / GetCotizacion()) == (e.GetCantidad() * Euro.GetCotizacion()));
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return (p1.cantidad == p2.cantidad);
        }
    }
}
