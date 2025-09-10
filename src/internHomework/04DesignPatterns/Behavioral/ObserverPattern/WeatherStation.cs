using System.Collections.Generic;

namespace ObserverPattern
{
    class WeatherStation : ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;

        public WeatherStation()
        {
            _observers = new List<IObserver>();
        }
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_temperature,_humidity);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void SetMeasurements(float temperature, float humidity)
        {
            _temperature = temperature;
            _humidity = humidity;
            NotifyObservers();
        }
    }
}
