using System;
using System.Collections.Generic;

namespace KnuthMorrisPratt
{
    public interface IFinderFactory<in T>
    {
        IFinder<T> CreateFrom(IEnumerable<T> word);
    }
}
