using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grados
{
    public class Kelvin
    {
        private double gradosKelvin;
        private double _kelvinToFahrenheit;

        private double KelvinToFahrenheit
        {
            get
            {
                return this._kelvinToFahrenheit;
            }
            set
            {
                _kelvinToFahrenheit = ((value * (9 / 5)) - 459.67);
            }
        }

        public double GetGradosKelvin()
        {
            return this.gradosKelvin;
        }

        public Kelvin()
        {

        }

        public Kelvin(double grados)
        {
            this.gradosKelvin = grados;
            this.KelvinToFahrenheit = grados;
        }

        public double GetKelvinToFahrenheit()
        {
            return this.KelvinToFahrenheit;
        }

        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius(new Fahrenheit(k.GetKelvinToFahrenheit()).GetFahrenheitToCelsius());
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit(k.GetKelvinToFahrenheit());
        }

        public static implicit operator Kelvin(double d)
        {
            return new Kelvin(d);
        }

        //bool operator !=
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return (k.GetKelvinToFahrenheit() == c.GetCelsiusToFahrenheit());
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return (f.GetFahrenheitToKelvin() == k.GetGradosKelvin());
        }

        public static bool operator !=(Kelvin k1, Kelvin k2)
        {
            return (k1.GetGradosKelvin() == k2.GetGradosKelvin());
        }

        //Kelvin operator -(Kelvin k, Celsius c)
        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin(k.GetKelvinToFahrenheit() - c.GetCelsiusToFahrenheit());
        }

        //Fahrenheit operator -(Fahrenheit f, Kelvin k)
        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.GetKelvinToFahrenheit() - f.GetGradosFahrenheit());
        }

        //Fahrenheit operator +(Fahrenheit f, Celsius c)
        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin(k.GetKelvinToFahrenheit() + c.GetCelsiusToFahrenheit());
        }

        //Fahrenheit operator +(Fahrenheit f, Kelvin k)
        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin(k.GetKelvinToFahrenheit() + f.GetGradosFahrenheit());
        }

        //bool operator ==
        public static bool operator ==(Kelvin k, Celsius c)
        {
            return (k.GetKelvinToFahrenheit() == c.GetCelsiusToFahrenheit());
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return (f.GetFahrenheitToKelvin() == k.GetGradosKelvin());
        }

        public static bool operator ==(Kelvin k1, Kelvin k2)
        {
            return (k1.GetGradosKelvin() == k2.GetGradosKelvin());
        }
    }
}
