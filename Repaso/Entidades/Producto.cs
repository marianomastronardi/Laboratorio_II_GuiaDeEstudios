using System;

namespace Entidades
{
  public class Producto
  {
    private string codigoDeBarra;
    private string marca;
    private float precio;

    public Producto(string codbarra, string marc, float price)
    {
      this.codigoDeBarra = codbarra;
      this.marca = marc;
      this.precio = price;
    }

    public static explicit operator string(Producto p)
    {
      return p.codigoDeBarra;
    }

    public static bool operator ==(Producto p1, Producto p2)
    {
      return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
    }

    public static bool operator !=(Producto p1, Producto p2)
    {
      return !(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
    }

    public static bool operator ==(Producto p1, string marca)
    {
      return (p1.GetMarca() == marca);
    }

    public static bool operator !=(Producto p1, string marca)
    {
      return !(p1.GetMarca() == marca);
    }

    public string GetMarca()
    {
      return this.marca;
    }

    public float GetPrecio()
    {
      return this.precio;
    }

    public static string MostrarProducto(Producto p)
    {
      return "Codigo de Barra: " +  (string)p + " Marca: " + p.marca + " Precio: " + p.precio.ToString();
    }


  }
}
