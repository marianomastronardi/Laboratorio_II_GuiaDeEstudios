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

        public double GetFahrenheitToKelvin()
        {
            return this.KelvinToFahrenheit;
        }
    }
}
