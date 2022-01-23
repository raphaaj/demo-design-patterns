using System;
using System.Collections.Generic;
using System.Text;

namespace observer_csharp
{
    public class Weather
    {
        public float Temperature { get; }

        public float Humidity { get; }

        public float Pressure { get; }

        public Weather(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
        }
    }

    public class WeatherData : IObservable<Weather>
    {
        private readonly List<IObserver<Weather>> Observers;
        private Weather Weather;

        public WeatherData()
        {
            Observers = new List<IObserver<Weather>>();
        }

        public IDisposable Subscribe(IObserver<Weather> observer)
        {
            if (!Observers.Contains(observer))
                Observers.Add(observer);

            return new Unsubscriber(Observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Weather>> _observers;
            private IObserver<Weather> _observer;

            public Unsubscriber(List<IObserver<Weather>> observers, IObserver<Weather> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (var o in Observers)
            {
                o.OnNext(Weather);
            }
        }

        public void MeadurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Weather = new Weather(temperature, humidity, pressure);
            MeadurementsChanged();
        }
    }
}
