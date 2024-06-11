class Temperature
{
    private double celsius;

    public Temperature(double celsiusTemp = 0, double kelvinTemp = 0, double fahrenheitTemp = 0)
    {
        if (celsiusTemp != 0)
        {
            celsius = celsiusTemp;
        }
        else if (kelvinTemp != 0)
        {
            celsius = KelvinToCelsius(kelvinTemp);
        }
        else if (fahrenheitTemp != 0)
        {
            celsius = FahrenheitToCelsius(fahrenheitTemp);
        }
        else
        {
            throw new ArgumentException("At least one temperature value must be provided.");
        }
    }

    public double GetCelsius()
    {
        return celsius;
    }

    public double GetKelvin()
    {
        return CelsiusToKelvin(celsius);
    }

    public double GetFahrenheit()
    {
        return CelsiusToFahrenheit(celsius);
    }

    private double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    private double KelvinToCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }

    private double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    private double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
