using System;
using System.Collections.Generic;

namespace KnuthMorrisPratt
{
    public class FinderFactory<T> : IFinderFactory<T>
    {
        public IFinder<T> CreateFrom(IEnumerable<T> word)
        {
            return new Finder<T>(word);
        }
    }
}
