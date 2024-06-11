
using System;

class MainProgram
{
    static void Main(string[] args)
    {

        var temperatureInitWithCelsius = new Temperature(celsiusTemp: 42);


        Console.WriteLine($"Temperatura em Fahrenheit: {temperatureInitWithCelsius.GetFahrenheit()}");
        Console.WriteLine($"Temperatura em Kelvin: {temperatureInitWithCelsius.GetKelvin()}");

        var temperatureInitWithKelvin = new Temperature(kelvinTemp: 360.72);

        Console.WriteLine($"Temperatura em Celsius: {temperatureInitWithKelvin.GetCelsius()}");
    }
}