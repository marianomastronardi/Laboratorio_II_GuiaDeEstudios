using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
  class ClassEjercicio26
  {
    static void Main(string[] args)
    {
      Random rand = new Random();
      // Generate and display 5 random byte (integer) values.
      int[] numeros = new int[20];
      for (int j = 0; j < 20; j++)
        numeros[j] = rand.Next();
      Console.WriteLine("Muestro los 20 valores cargados:");
      foreach (byte byteValue in numeros)
        Console.WriteLine(byteValue);
      Console.WriteLine();

      Console.WriteLine("Muestro los positivos ordenados en forma descendiente:");
      int[] int_desc = new int[20];
      int max;
      int idx;
      int idxaux;
      for (int i = 0; i < numeros.Length; i++)
      {
        max = 0;
        idx = 0;
        idxaux = 0;
        foreach (byte byteValue in numeros)
        {
          if(byteValue >= 0)
          {
            if(byteValue > max)
            {
              idxaux = idx;
            }
          }
          idx++;
        }
        int_desc[i] = numeros[idx];
        numeros[idx] = -1;
      }
      foreach(int bytedesc in int_desc)
        Console.WriteLine(bytedesc);
      Console.WriteLine();

      Console.ReadLine();
    }
  }
}
