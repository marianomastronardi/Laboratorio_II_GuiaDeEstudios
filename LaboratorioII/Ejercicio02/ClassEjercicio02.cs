using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class ClassEjercicio02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";
            //string formatodecimal = "{0,10:#,###.00}";
            int iInput = 0;
            bool repeat = false;

            while(!repeat)
            {
                Console.WriteLine("Ingrese un numero: ");
                repeat = int.TryParse(Console.ReadLine(), out iInput);

                if (iInput <= 0)
                {
                    Console.WriteLine("ERROR Reingrese el numero!");
                    Console.ReadKey();
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Su numero ingresado al cuadrado es: " + Math.Pow((double)iInput, 2));
                    Console.WriteLine("Su numero ingresado al cuadrado es: " + Math.Pow((double)iInput, 3));
                    Console.ReadKey();
                }
            }
        }
    }
}
