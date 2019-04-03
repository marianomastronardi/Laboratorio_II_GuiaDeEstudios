using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
  public class Estante
  {
    private Producto[] producto;
    private int ubicacionEstante;

    private Estante(int capacidad)
    {
      producto = new Producto[capacidad];

    }

    public Estante(int capacidad, int ubicacion) : this(capacidad)
    {

    }

    public static bool operator ==(Estante e, Producto p)
    {
      bool productoExiste = false;

      foreach(Producto prod in e.producto)
      {
        if(!(prod is null) && !(p is null))
          productoExiste = (prod == p);
        if (productoExiste) break;
      }
      return productoExiste;
    }

    public static bool operator !=(Estante e, Producto p)
    {
      return !(e == p);
    }

    public static bool operator +(Estante e, Producto p)
    {
      if(e != p)
      {
        for(int i = 0; i < e.producto.Length;i++)
        {
          if(e.producto[i] is null)
          {
            e.producto[i] = p;
            return true;
          }
        }
      }
      return false;
    }

    public static Estante operator -(Estante e, Producto p)
    {
        for (int i = 0; i < e.producto.Length; i++)
        {
          if (e.producto[i] == p) 
          {
            e.producto[i] = null;
            i = e.producto.Length;
          }
        }
      return e;
    }

    public Producto[] GetProducto()
    {
      return this.producto;
    }

    public static string MostrarEstante(Estante e)
    {
      string ret = e.ubicacionEstante.ToString() + " ";
      foreach(Producto p in e.producto)
      {
        if (!(p is null))
        ret += Producto.MostrarProducto(p) + " ";
      }
      return ret;
    }

  }

}
