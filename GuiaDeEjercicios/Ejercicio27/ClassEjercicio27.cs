using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
  class ClassEjercicio27
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 27";

      Random rand = new Random();
      List<int> listRmd = new List<int>();
      Stack<int> stackRmd = new Stack<int>();
      Queue<int> queueRmd = new Queue<int>();

      for (int j = 0; j < 20; j++)
      {
        listRmd.Add(rand.Next(0, 500));
        //stackRmd.Push(rand.Next(0, 500));
        //queueRmd.Enqueue(rand.Next(0, 500));
      }

      Console.WriteLine("Muestro los 20 valores cargados en la Lista:");
      foreach (int item in listRmd)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine();

      Console.ReadKey();
      /*
            Console.WriteLine("Muestro los 20 valores cargados en la Pila:");
            foreach (int item in stackRmd)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadKey();

            Console.WriteLine("Muestro los 20 valores cargados en la Cola:");
            foreach (int item in queueRmd)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadKey();
            */

      //ordeno la lista
      listRmd.Sort();

      foreach (int item in listRmd)
        stackRmd.Push(item);

      listRmd.Reverse();
      foreach (int item in listRmd)
        queueRmd.Enqueue(item);

      
      //muestro los 20 valores de cada uno
      Console.WriteLine("Muestro los 20 valores cargados en la Lista en forma descendiente:");
      listRmd.ForEach(l => Console.WriteLine(l.ToString()));
      Console.ReadKey();

      Console.WriteLine("Muestro los 20 valores cargados en la Pila en forma descendiente:");
      for (int i = stackRmd.Count() - 1; i > 0; i--)
        Console.WriteLine(stackRmd.Pop());
      Console.ReadKey();

      Console.WriteLine("Muestro los 20 valores cargados en la Cola en forma descendiente:");
      for (int j = queueRmd.Count() - 1; j > 0; j--)
        Console.WriteLine(queueRmd.Dequeue());
      Console.ReadKey();

    }
  }
}
