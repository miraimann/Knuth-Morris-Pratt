using System;
using System.Collections.Generic;

namespace KnuthMorrisPratt
{
    public class FinderFactory<T> : IFinderFactory<T>
    {
        public IFinder<T> CreateFrom(IEnumerable<T> pattern)
        {
            return new Finder<T>(pattern);
        }
    }
}
