using System.Collections.Generic;

namespace KnuthMorrisPratt.Tests
{
    public class Case<T>  
    {
        public Case(IEnumerable<T> pattern, IEnumerable<T> sequence)
        {
            Pattern = pattern;
            Sequence = sequence;
        }

        public IEnumerable<T> Pattern { get; private set; }

        public IEnumerable<T> Sequence { get; private set; }
    }
}
