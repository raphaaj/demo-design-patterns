using System;
using System.Collections.Generic;
using System.Text;

namespace singleton
{
    public class ChocolateBoilerUnsafe
    {
        private bool IsEmpty;
        private bool IsBoiled;

        private static ChocolateBoilerUnsafe BoilerInstance;

        public static ChocolateBoilerUnsafe GetBoiler()
        {
            if(BoilerInstance == null) BoilerInstance = new ChocolateBoilerUnsafe();
            return BoilerInstance;
        }

        private ChocolateBoilerUnsafe()
        {
            IsEmpty = true;
            IsBoiled = false;
        }

        public void Fill()
        {
            if (IsEmpty)
            {
                IsEmpty = false;
                IsBoiled = false;
            }
        }

        public void Drain()
        {
            if(!IsEmpty && IsBoiled)
            {
                IsEmpty = true;
            }
        }

        public void Boil()
        {
            if(!IsEmpty && !IsBoiled)
            {
                IsBoiled = true;
            }
        }
    }
}
