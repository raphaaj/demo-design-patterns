using System;
using System.Collections.Generic;
using System.Text;

namespace observer_csharp
{
    class CurrentConditionsDisplay : IObserver<Weather>, IDisplayElement, IDisposable
    {
        private Weather Weather;
        private readonly IDisposable unsubscriber;

        public CurrentConditionsDisplay(IObservable<Weather> weatherDataProvider)
        {
            unsubscriber = weatherDataProvider.Subscribe(this);
        }

        public void OnNext(Weather weather)
        {
            Weather = weather;
            Display();
        }

        public void OnCompleted()
        {
            Console.WriteLine("Transmission ended.");
            Dispose();
        }

        public void OnError(Exception e)
        {
            Console.WriteLine("Erro.");
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: {Weather.Temperature}°F, {Weather.Humidity}% humidity, {Weather.Pressure} mmHg");
        }

        public void Dispose()
        {
            if (unsubscriber != null)
                unsubscriber.Dispose();
        }
    }
}
