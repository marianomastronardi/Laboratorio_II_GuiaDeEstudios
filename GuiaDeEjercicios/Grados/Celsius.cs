namespace Grados
{
    public class Celsius
    {
        private double gradosCelsius;
        private double _celsiusFahrenheit;

        private double CelsiusToFahrenheit
        {
            get
            {
                return this._celsiusFahrenheit;
            }
            set
            {
                _celsiusFahrenheit = ((value * (9 / 5)) + 32);
            }
        }

        public double GetGradosCelsius()
        {
            return this.gradosCelsius;
        }

        public Celsius()
        {

        }

        public Celsius(double grados)
        {
            this.gradosCelsius = grados;
            this.CelsiusToFahrenheit = grados;
        }

        public double GetFahrenheitToCelsius()
        {
            return this.CelsiusToFahrenheit;
        }
    }
}
