using System;
using System.Collections.Generic;
using System.Text;

namespace iterator
{
    public class DinnerMenuIterator : IIterator<MenuItem>
    {
        private readonly MenuItem[] items;
        private int position;

        public DinnerMenuIterator(MenuItem[] items)
        {
            this.items = items;
            position = 0;
        }

        public bool HasNext()
        {
            if (position >= items.Length || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public MenuItem Next()
        {
            MenuItem item = items[position];
            position += 1;

            return item;
        }
    }
}
