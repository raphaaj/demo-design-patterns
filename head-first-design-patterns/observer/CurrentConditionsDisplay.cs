using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float Temperature;
        private float Humidity;
        private float Pressure;
        private ISubject WeatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            WeatherData = weatherData;
            WeatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: {Temperature}°F, {Humidity}% humidity, {Pressure} mmHg");
        }
    }
}
