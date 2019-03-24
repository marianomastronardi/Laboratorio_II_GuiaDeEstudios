using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class ClassEjercicio03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";
            int iInput = 0;
            int cont = 0;
            bool ok = false;

            while (!ok)
            {
                Console.Write("Ingrese un numero: ");
                ok = int.TryParse(Console.ReadLine(), out iInput);
            }

            for (int i = 1; i <= iInput; i++)
            {
                cont = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
