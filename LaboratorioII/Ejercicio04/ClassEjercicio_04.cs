using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class ClassEjercicio_04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";
            int cont = 0;
            int acum = 0;

            for (int i = 1; cont <= 4; i++)
            {
                acum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i%j == 0)
                    {
                        acum+=j;
                    }
                }
                if (acum == i)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

        }
    }
}
