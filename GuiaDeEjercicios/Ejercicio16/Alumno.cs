using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
  class Alumno
  {
    public byte nota1;
    public byte nota2;
    public float notaFinal;
    public string apellido;
    public int legajo;
    public string nombre;
    public static string colegio;

    public Alumno(string apellido, string nombre)
    {
      this.nombre = nombre;
      this.apellido = apellido;
    }

    static Alumno()
    {
      colegio = "UTN";
    }

    void CalcularFinal()
    {

    }

    void Estudiar(byte notaUno, byte notaDos)
    {

    }

    public string Mostrar()
    {
      return colegio + " " + this.apellido + " " + this.nombre + " ";
    }
  }
}
