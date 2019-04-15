using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    public class Fahrenheit
    {
        private double gradosFahrenheit;
        private double _fahrenheitToCelsius;
        private double _fahrenheitToKelvin;

        private double FahrenheitToCelsius
        {
            get
            {
                return this._fahrenheitToCelsius;
            }
            set
            {
                _fahrenheitToCelsius = ((value - 32) * (5 / 9));
            }
        }

        private double FahrenheitToKelvin
        {
            get
            {
                return this._fahrenheitToKelvin;
            }
            set
            {
                _fahrenheitToKelvin = ((value + 459.67) * (5 / 9));
            }
        }

        public Fahrenheit()
        {

        }

        public Fahrenheit(double grados)
        {
            this.gradosFahrenheit = grados;
            this.FahrenheitToCelsius = grados;
            this.FahrenheitToKelvin = grados;
        }

        public double GetGradosFahrenheit()
        {
            return this.gradosFahrenheit;
        }

        public double GetFahrenheitToCelsius()
        {
            return this.FahrenheitToCelsius;
        }

        public double GetFahrenheitToKelvin()
        {
            return this.FahrenheitToKelvin;
        }

        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius(f.GetFahrenheitToCelsius());
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin(f.GetFahrenheitToKelvin());
        }

        public static implicit operator Fahrenheit(double d)
        {
            return new Fahrenheit(d);
        }

        //bool operator !=
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return (f.GetFahrenheitToCelsius() == c.GetGradosCelsius());
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return (f.GetFahrenheitToKelvin() == k.GetGradosKelvin());
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return (f1.GetGradosFahrenheit() == f2.GetGradosFahrenheit());
        }

        //Fahrenheit operator -(Fahrenheit f, Celsius c)
        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.GetGradosFahrenheit() - c.GetCelsiusToFahrenheit());
        }

        //Fahrenheit operator -(Fahrenheit f, Kelvin k)
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.GetGradosFahrenheit() - k.GetKelvinToFahrenheit());
        }

        //Fahrenheit operator +(Fahrenheit f, Celsius c)
        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.GetGradosFahrenheit() + c.GetCelsiusToFahrenheit());
        }

        //Fahrenheit operator +(Fahrenheit f, Kelvin k)
        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.GetGradosFahrenheit() + k.GetKelvinToFahrenheit());
        }

        //bool operator ==
        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return (f.GetFahrenheitToCelsius() == c.GetGradosCelsius());
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            return (f.GetFahrenheitToKelvin() == k.GetGradosKelvin());
        }

        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return (f1.GetGradosFahrenheit() == f2.GetGradosFahrenheit());
        }
    }
}
