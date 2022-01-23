using System;
using System.Collections.Generic;
using System.Text;

namespace singleton
{
    class ChocolateBoilerSafe2
    {
        private bool IsEmpty;
        private bool IsBoiled;

        private static readonly object balanceLock = new object();
        private static ChocolateBoilerSafe2 BoilerInstance;

        public static ChocolateBoilerSafe2 GetBoiler()
        {
            /*
             * As chamadas ao método GetBoiler são realizadas de forma sequencial, o que pode gerar problemas de performance.
             * Verificar estratégias implementadas no ChocolateBoilerSafe1 e no ChocolateBoilerSafe3.
             */
            lock (balanceLock) 
            {
                if (BoilerInstance == null) BoilerInstance = new ChocolateBoilerSafe2();
                return BoilerInstance;
            }
        }

        private ChocolateBoilerSafe2()
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
