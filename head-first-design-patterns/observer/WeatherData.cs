using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    class WeatherData : ISubject
    {
        private List<IObserver> Observers;
        private float Temperature;
        private float Humidity;
        private float Pressure;

        public WeatherData()
        {
            Observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            Observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var o in Observers)
            {
                o.Update(Temperature, Humidity, Pressure);
            }
        }

        public void MeadurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeadurementsChanged();
        }
    }
}
