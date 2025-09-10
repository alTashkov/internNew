using System;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            WeatherDisplay weatherDisplay1 = new WeatherDisplay();
            WeatherDisplay weatherDisplay2 = new WeatherDisplay();

            weatherStation.AddObserver(weatherDisplay1);
            weatherStation.AddObserver(weatherDisplay2);

            weatherStation.SetMeasurements(25,45);
            Console.WriteLine();
            Console.WriteLine("Weather conditions have changed!");
            weatherStation.SetMeasurements(27, 57);
        }
    }
}
