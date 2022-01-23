using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace iterator
{
    public class CafeMenuIterator : IIterator<MenuItem>
    {
        private readonly IDictionaryEnumerator items;

        public CafeMenuIterator(Hashtable items)
        {
            this.items = items.GetEnumerator();
        }

        public bool HasNext()
        {
            return items.MoveNext();
        }

        public MenuItem Next()
        {
            return (MenuItem)items.Value;
        }
    }
}
