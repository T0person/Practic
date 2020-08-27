using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FastDiner.Interfaces
{
    public interface Menu
    {
        public IEnumerator CreateIterator();
    }
}
