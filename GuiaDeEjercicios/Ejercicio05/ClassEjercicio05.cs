using System;

namespace Ejercicio05
{
    class ClassEjercicio05
    {
        static void Main(string[] args)
        {
            //Centro Numerico
            Console.Title = "Ejercicio Nro 05";
            int iInput = 0;
            bool ok = false;
            int acummenor = 0;
            int acummayor = 0;

            while (!ok)
            {
                Console.WriteLine("Ingrese un numero: ");
                ok = int.TryParse(Console.ReadLine(), out iInput);
            }


            for (int i = 2; i <= iInput; i++)
            {
                acummenor = 0;
                acummayor = 0;

                for (int j = 1; acummenor > acummayor || (acummayor == 0 && acummenor == 0); j++)
                {
                    if (j != i)
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
