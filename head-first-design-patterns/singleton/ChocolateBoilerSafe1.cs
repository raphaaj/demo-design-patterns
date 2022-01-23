using System;
using System.Collections.Generic;
using System.Text;

namespace singleton
{
    class ChocolateBoilerSafe1
    {
        private bool IsEmpty;
        private bool IsBoiled;

        private static ChocolateBoilerSafe1 BoilerInstance = new ChocolateBoilerSafe1();

        public static ChocolateBoilerSafe1 GetBoiler()
        {
            return BoilerInstance;
        }

        private ChocolateBoilerSafe1()
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
            if (!IsEmpty && IsBoiled)
            {
                IsEmpty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty && !IsBoiled)
            {
                IsBoiled = true;
            }
        }
    }
}
