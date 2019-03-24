using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class ClassEjercicio05
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";
            int iInput = 0;
            bool ok = false;
            int acummenor = 0;
            int acummayor = 0;

            while (!ok)
            {
                Console.Write("Ingrese un numero: ");
                ok = int.TryParse(Console.ReadLine(), out iInput);
            }


            for (int i = 1; i <= iInput; i++)
            {
                acummenor = 0;
                acummayor = 0;

                for (int j = 1; acummenor >= acummayor; j++)
                {
                    if (j % i == 0)
                    {
                        if (j < i)
                            acummenor += j;
                        else
                            acummayor += j;
                    }
                }
                if (acummenor == acummayor && acummayor > 0)
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
