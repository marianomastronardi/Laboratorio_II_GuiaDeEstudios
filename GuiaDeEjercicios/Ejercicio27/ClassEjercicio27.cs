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
                stackRmd.Push(rand.Next(0, 500));
                queueRmd.Enqueue(rand.Next(0, 500));
            }

            Console.WriteLine("Muestro los 20 valores cargados en la Lista:");
            foreach(int item in listRmd)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadKey();

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
            //ordeno la lista
            listRmd.Sort();
            listRmd.Reverse();

            //ordeno la pila
            var s = stackRmd.ToArray().ToList();
            s.Sort();
            s.Reverse();
            stackRmd = new Stack<int>(s);

            //ordeno la cola
            var q = queueRmd.ToArray().ToList();
            q.Sort();
            q.Reverse();
            queueRmd = new Queue<int>(q);

            //muestro los 20 valores de cada uno
            Console.WriteLine("Muestro los 20 valores cargados en la Lista en forma descendiente:");
            listRmd.ForEach(l => Console.WriteLine(l.ToString()));
            Console.ReadKey();

            Console.WriteLine("Muestro los 20 valores cargados en la Pila en forma descendiente:");
            stackRmd.ToList().ForEach(ss => Console.WriteLine(ss.ToString()));
            Console.ReadKey();

            Console.WriteLine("Muestro los 20 valores cargados en la Cola en forma descendiente:");
            queueRmd.ToList().ForEach(qq => Console.WriteLine(qq.ToString()));
            Console.ReadKey();

        }
    }
}
