using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace Entidades
{
  public class Jugador : Persona
  {
    private float altura;

    private float peso;

    private Posicion posicion;

    public Posicion Posicion
    {
      get { return this.posicion; }
      //set { this.posicion = value; }
    }

    public float Peso
    {
      get { return this.peso; }
      //set { this.peso = value; }
    }

    public float Altura
    {
      get { return this.altura; }
      //set { this.altura = value; }
    }

    public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre, apellido, edad, dni)
    {
      this.peso = peso;
      this.altura = altura;
      this.posicion = posicion;
    }

    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder(base.Mostrar());
      sb.Append("Peso: " + this.Peso + "\n");
      sb.Append("Altura: " + this.Altura + "\n");
      sb.Append("Posicion: " + this.Posicion + "\n");

      return sb.ToString();
    }

    public override bool ValidarAptitud()
    {
      return this.Edad <= 40 && this.ValidarEstadoFisico();
    }

    public bool ValidarEstadoFisico()
    {
      float IMC = this.Peso / (float)Math.Pow(this.Altura, 2);
      return IMC >= 18.5 && IMC <= 25;
    }
  }
}
