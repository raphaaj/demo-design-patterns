using System;
using System.Collections.Generic;
using System.Text;

namespace singleton
{
    class ChocolateBoilerSafe3
    {
        private bool IsEmpty;
        private bool IsBoiled;

        private static readonly object balanceLock = new object();
        private static ChocolateBoilerSafe3 BoilerInstance;

        public static ChocolateBoilerSafe3 GetBoiler()
        {
            if (BoilerInstance == null)
            {
                /*
                 * A execução de métdo GetBoiler é sincronizada apenas enquando BoilerInstance for nulo, o que resulta em uma
                 * estratégia mais eficiente do que a implementada em ChocolateBoilerSafe2.
                 */
                lock (balanceLock)
                {
                    if (BoilerInstance == null)
                    {
                        BoilerInstance = new ChocolateBoilerSafe3();
                    }
                }
            }
            return BoilerInstance;
        }

        private ChocolateBoilerSafe3()
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
