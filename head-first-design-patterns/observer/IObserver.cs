using System;
using System.Collections.Generic;
using System.Text;

namespace observer
{
    interface IObserver
    {
        public void Update(float temp, float humidity, float pressure);
    }
}
