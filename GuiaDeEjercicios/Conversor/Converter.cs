using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    public class Converter
    {
        public static string DecimalBinario(double d)
        {
            int cociente;
            string numero = string.Empty;
            StringCollection restos = new StringCollection();
            bool isNumber = int.TryParse(d.ToString(), out cociente);
            int rescociente = 0;
            if (isNumber)
            {
                if (cociente == 0)
                {
                    restos.Add("0");
                }
                else
                {
                    //guardo en la coleccion los restos
                    while (cociente >= 2)
                    {
                        rescociente = cociente % 2;
                        restos.Add((rescociente).ToString());
                        cociente = cociente / 2;
                    }
                    restos.Add("1");
                }


                //recorro el stringCollection de atras para adelante
                StringEnumerator eRestos = restos.GetEnumerator();
                int i = restos.Count - 1;
                string[] ret = new string[i + 1];

                //dejo los items en mi array
                while (eRestos.MoveNext())
                {
                    ret[i] = eRestos.Current;
                    i--;
                }

                numero = string.Empty;
                //ahora devuelvo el numero convertido a binario
                for (int j = 0; j < ret.Length; j++)
                {
                    numero += ret[j];
                }
            }

            return isNumber ? numero : "Valor Inválido";
        }

        public static double BinarioDecimal(string numero)
        {
            //Declaro un array can tantos elementos como carateres tenga el parametro numero
            double ret = 0;
            bool isNumber = true;
            bool isBinary = numero.Replace("0", "").Replace("1", "").Length == 0;
            int bit = 0;
            int i = 0;
            int j = numero.Length - 1;

            if (isNumber && isBinary)
            {
                while (i < numero.Length)
                {
                    isNumber = int.TryParse(numero.Substring(i, 1), out bit);
                    if (!isNumber)
                        break;
                    ret += (bit * (int)Math.Pow(2, j));
                    i++;
                    j--;
                }
            }

            return (isNumber && isBinary) ? ret : 0;
        }
    }

    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string n)
        {
            this.numero = n;
        }

        public static implicit operator NumeroBinario(string objBinario)
        {
            return new NumeroBinario(objBinario);
        }
    }

    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double n)
        {
            this.numero = n;
        }

        public static implicit operator NumeroDecimal(double objDecimal)
        {
            return new NumeroDecimal(objDecimal);
        }
    }
}
