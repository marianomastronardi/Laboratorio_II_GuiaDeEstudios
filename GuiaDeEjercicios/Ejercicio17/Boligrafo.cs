using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
  class Boligrafo
  {
    public const short cantidadTintaMaxima = 100;
    public ConsoleColor color;
    public short tinta;

    public Boligrafo(short tinta, ConsoleColor color)
    {
      this.tinta = tinta;
      this.color = color;
    }

    public ConsoleColor GetColor()
    {
      return this.color;
    }

    public short GetTinta()
    {
      return this.tinta;
    }

    public bool Pintar(int gasto, out string dibujo)
    {
      bool canPrintAll = true;
      dibujo = string.Empty;

        for(int i = ((this.tinta - gasto) > 0?gasto:this.tinta); i > 0; i--)
        {
          dibujo += "*";
        }
        canPrintAll = !(gasto > this.tinta);
      gasto = gasto * -1;
      this.SetTinta((Int16)gasto);
      
      return canPrintAll;
    }

    public void Recargar()
    {
      this.SetTinta(cantidadTintaMaxima);
    }

    public void SetTinta(short tinta)
    {
      if (tinta >= 0)
      {
        //cargar tinta
        if (this.tinta + tinta > cantidadTintaMaxima)
        {
          this.tinta = cantidadTintaMaxima;
        }
        else
        {
          this.tinta += tinta;
        }

      }
      else
      {
        //gastar tinta
        if (this.tinta + tinta < 0)
        {
          this.tinta = 0;
        }
        else
        {
          this.tinta += tinta;
        }
      }
    }

  }
}
