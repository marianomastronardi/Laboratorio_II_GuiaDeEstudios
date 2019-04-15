using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grados;

namespace Ejercicio21
{
    class ClassEjercicio21
    {
        static void Main(string[] args)
        {
            //Celsius
            Console.WriteLine("Declaro Celsius de 30º");
            Celsius c30 = new Celsius(30);
            Console.WriteLine("Celsius To Fahreinheit: " + c30.GetCelsiusToFahrenheit());


            Console.ReadKey();
        }
    }
}
