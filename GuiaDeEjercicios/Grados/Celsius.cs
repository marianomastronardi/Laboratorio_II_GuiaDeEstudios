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

        public double GetCelsiusToFahrenheit()
        {
            return this.CelsiusToFahrenheit;
        }

        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin(new Fahrenheit(c.GetCelsiusToFahrenheit()).GetFahrenheitToKelvin());
        }

        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(c.GetCelsiusToFahrenheit());
        }

        public static implicit operator Celsius(double d)
        {
            return new Celsius(d);
        }

        //bool operator !=
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return (k.GetKelvinToFahrenheit() == c.GetCelsiusToFahrenheit());
        }

        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return (f.GetGradosFahrenheit() == c.GetCelsiusToFahrenheit());
        }

        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return (c1.GetGradosCelsius() == c2.GetGradosCelsius());
        }

        //Celsius operator -(Celsius c, Kelvin k)
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius(k.GetKelvinToFahrenheit() - c.GetCelsiusToFahrenheit());
        }

        //Celsius operator -(Celsius c, Fahrenheit f)
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.GetCelsiusToFahrenheit() - f.GetGradosFahrenheit());
        }

        //Celsius operator +(Celsius c, Kelvin k)
        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius(k.GetKelvinToFahrenheit() + c.GetCelsiusToFahrenheit());
        }

        //Celsius operator +(Celsius c, Fahrenheit f)
        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius(c.GetCelsiusToFahrenheit() + f.GetGradosFahrenheit());
        }

        //bool operator ==
        public static bool operator ==(Celsius c, Kelvin k)
        {
            return (k.GetKelvinToFahrenheit() == c.GetCelsiusToFahrenheit());
        }

        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return (f.GetGradosFahrenheit() == c.GetCelsiusToFahrenheit());
        }

        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return (c1.GetGradosCelsius() == c2.GetGradosCelsius());
        }
    }
}
