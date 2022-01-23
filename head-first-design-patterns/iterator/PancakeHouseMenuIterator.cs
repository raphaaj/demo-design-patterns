using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iterator
{
    public class PancakeHouseMenuIterator : IIterator<MenuItem>
    {
        private readonly IEnumerator<MenuItem> items;
        
        public PancakeHouseMenuIterator(List<MenuItem> items)
        {
            this.items = items.GetEnumerator();
        }

        public bool HasNext()
        {
            return items.MoveNext();
        }

        public MenuItem Next()
        {
            return items.Current;
        }
    }
}
