using System;
using System.Collections.Generic;

namespace KnuthMorrisPratt
{
    internal class Finder<T> : IFinder<T>
    {
        public int FindIn(IEnumerable<T> sequence)
        {
            throw new NotImplementedException();
        }

        public int FindLastIn(IEnumerable<T> sequence)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> FindAllIn(IEnumerable<T> sequence)
        {
            throw new NotImplementedException();
        }

        public bool ExistsIn(IEnumerable<T> sequence)
        {
            throw new NotImplementedException();
        }
    }
}
