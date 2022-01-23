using System;
using System.Collections.Generic;
using System.Text;

namespace iterator
{
    public interface IIterator<T>
    {
        bool HasNext();

        T Next();
    }
}
