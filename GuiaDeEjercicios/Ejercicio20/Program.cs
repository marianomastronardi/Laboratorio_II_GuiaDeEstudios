using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
  class Program
  {
    static void Main(string[] args)
    {
            Console.Title = "Ejercicio Nro 20";
            //string formatodecimal = "{0,10:#,###.00}";
            
            Console.WriteLine("Inicializo 3 Dolares: ");
            Dolar d = new Dolar(3);

            Console.WriteLine("Inicializo 2 Euros: ");
            Euro e = new Euro(2);

            Console.WriteLine("Inicializo 200 Pesos: ");
            Pesos p = new Pesos(200);

            Console.WriteLine("Inicializo double 75: ");
            double db = 75;

            //Titulo
            Console.WriteLine();
            Console.WriteLine("************************");
            Console.WriteLine("**********DOLAR*********");
            Console.WriteLine("************************");
            Console.WriteLine();

            Console.WriteLine("explicit operator Euro(Dolar d): ");
            Euro eoEtoD = (Euro)d;
            Console.WriteLine("eoEtoD: " + Math.Round(eoEtoD.GetCantidad(),2));

            Console.WriteLine("explicit operator Pesos(Dolar d): ");
            Pesos eoPtoD = (Pesos)d;
            Console.WriteLine("eoPtoD: " + Math.Round(eoPtoD.GetCantidad(), 2));

            Console.WriteLine("implicit operator Dolar(double d): ");
            Dolar ioDtoDou = (Dolar)db;
            Console.WriteLine("ioDtoDou: " + Math.Round(ioDtoDou.GetCantidad(), 2));

            //bool operator ==
            //Dolar--Euro
            Console.WriteLine("bool operator !=(Dolar d, Euro e): ");
            if(d == eoEtoD)
            {
                Console.WriteLine("d == eoEtoD");
            }
            else
            {
                Console.WriteLine("d != eoEtoD");
            }

            //bool operator !=
            //Dolar--Euro
            Console.WriteLine("Inicializo 5 Euros: e5");
            Euro e5 = new Euro(5);
            Console.WriteLine("bool operator !=(Dolar d, Euro e): ");
            if (d == e5)
            {
                Console.WriteLine("d == e5");
            }
            else
            {
                Console.WriteLine("d != e5");
            }

            //bool operator ==
            //Dolar--Pesos
            Console.WriteLine("bool operator !=(Dolar d, Pesos p): ");
            if (d == eoPtoD)
            {
                Console.WriteLine("d == eoPtoD");
            }
            else
            {
                Console.WriteLine("d != eoPtoD");
            }

            //bool operator !=
            //Dolar--Pesos
            Console.WriteLine("Inicializo 500 Pesos: p500");
            Pesos p500 = new Pesos(500);
            Console.WriteLine("bool operator !=(Dolar d, Pesos p): ");
            if (d == p500)
            {
                Console.WriteLine("d == p500");
            }
            else
            {
                Console.WriteLine("d != p500");
            }

            //bool operator ==
            //Dolar--Dolar
            Console.WriteLine("bool operator !=(Dolar d1, Dolar d2): ");
            Console.WriteLine("Inicializo 3 Dolares: d3");
            Dolar d3 = new Dolar(3);
            if (d == d3)
            {
                Console.WriteLine("d == d3");
            }
            else
            {
                Console.WriteLine("d != d3");
            }

            //bool operator !=
            //Dolar--Dolar
            Console.WriteLine("Inicializo 8 Dolares: d8");
            Dolar d8 = new Dolar(8);
            Console.WriteLine("bool operator !=(Dolar d1, Dolar d2): ");
            if (d == d8)
            {
                Console.WriteLine("d == d8");
            }
            else
            {
                Console.WriteLine("d != d8");
            }

            
            //Dolar operator -
            //(Dolar d, Euro e)
            Console.WriteLine("Dolar operator -(Dolar d, Euro e): ");
            Dolar dMinusDE = d8 - e5;
            Console.WriteLine("Inicializo Dolar dMinusDE(d8 - e5) ");
            Console.WriteLine(Math.Round(dMinusDE.GetCantidad(), 2));

            //Dolar operator -
            //(Dolar d, Pesos p)
            Console.WriteLine("Dolar operator -(Dolar d, Pesos p): ");
            Dolar dMinusDP = d8 - p500;
            Console.WriteLine("Inicializo Dolar dMinusDP(d8 - p500) ");
            Console.WriteLine(Math.Round(dMinusDP.GetCantidad(), 2));

            //Dolar operator +
            //(Dolar d, Euro e)
            Console.WriteLine("Dolar operator +(Dolar d, Euro e): ");
            Dolar dSumDE = d8 + e5;
            Console.WriteLine("Inicializo Dolar dSumDE(d8 + e5) ");
            Console.WriteLine(Math.Round(dSumDE.GetCantidad(), 2));

            //Dolar operator +
            //(Dolar d, Pesos p)
            Console.WriteLine("Dolar operator +(Dolar d, Pesos p): ");
            Dolar dSumDP = d8 + p500;
            Console.WriteLine("Inicializo Dolar dSumDP(d8 + p500) ");
            Console.WriteLine(Math.Round(dSumDP.GetCantidad(), 2));

            Console.ReadKey();
            
        }
  }
}
