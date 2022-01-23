using System;
using System.Collections.Generic;
using System.Text;

namespace iterator
{
    public interface IMenu
    {
        public IIterator<MenuItem> CreateIterator();
    }
}
