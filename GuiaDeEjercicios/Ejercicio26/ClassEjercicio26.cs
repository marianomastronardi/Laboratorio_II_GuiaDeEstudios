using System;

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
                numeros[j] = rand.Next(0, 500);
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
                foreach (int byteValue in numeros)
                {
                    if (byteValue > max)
                    {
                        max = byteValue;
                        idxaux = idx;
                    }
                    idx++;
                }
                int_desc[i] = numeros[idxaux];
                numeros[idxaux] = -1;
            }
            foreach (int bytedesc in int_desc)
                Console.WriteLine(bytedesc);
            Console.WriteLine();

            Console.WriteLine("Muestro los positivos ordenados en forma ascendente:");
            for (int k = int_desc.Length - 1; k >= 0; k--)
                Console.WriteLine(int_desc[k]);

            Console.ReadLine();
        }
    }
}
