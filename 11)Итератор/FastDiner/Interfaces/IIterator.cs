using System;
using System.Collections.Generic;
using System.Text;

namespace FastDiner.Interfaces
{
    public interface IIterator
    {
        bool hasNext();
        Object next();

        void remove();
    }
}
