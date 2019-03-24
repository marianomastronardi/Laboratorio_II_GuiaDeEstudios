using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseI
{
    class ClassEjercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            string formatodecimal = "{0,10:#,###.00}";
            int iInput = 0;
            int iMax = 0;
            int iMin = 0;
            double dAVG = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                int.TryParse(Console.ReadLine(), out iInput);
                if (i == 0)
                {
                    iMax = iInput;
                    iMin = iInput;
                }
                else
                {
                    if (iInput > iMax)
                        iMax = iInput;

                    if (iInput < iMin)
                        iMin = iInput;
                }

                dAVG += iInput;
            }

            Console.WriteLine("Numero Maximo: " + iMax);
            Console.WriteLine("Numero Minimo: " + iMin);
            Console.Write("Promedio: ");
            Console.WriteLine(formatodecimal, (dAVG / 5));
            Console.ReadKey();
        }
    }
}
