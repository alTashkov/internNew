using System;

namespace ObserverPattern
{
    class WeatherDisplay : IObserver
    {
        private float _temperature;
        private float _humidity;
        public void Update(float temperature, float humidity)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature} C degrees and {_humidity} % humidity");
        }
    }
}
