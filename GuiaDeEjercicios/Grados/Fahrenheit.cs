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
    }
}
