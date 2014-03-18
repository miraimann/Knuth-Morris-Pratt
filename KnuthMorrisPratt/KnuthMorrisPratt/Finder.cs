using System;
using System.Collections.Generic;
using System.Linq;

namespace KnuthMorrisPratt
{
    internal class Finder<T> : IFinder<T>
    {
        private readonly T[] _pattern;
        private readonly int[,] _dfa;
        private readonly Dictionary<T, int> _abc;

        public Finder(IEnumerable<T> word)
        {
            _pattern = word as T[] ?? word.ToArray();

            _abc = _pattern.Distinct()
                           .Select((v, i) => new { v, i })
                           .ToDictionary(o => o.v, o => o.i);

            _dfa = new int[_abc.Count, _pattern.Length]; 

            _dfa[0, 0] = 1;

            for (int i = 0, j = 1; j < _pattern.Length; i = _dfa[_abc[_pattern[j++]], i])
            {
                for (int c = 0; c < _abc.Count; c++)
                    _dfa[c, j] = _dfa[c, i];
                _dfa[_abc[_pattern[j]], j] = j + 1;
            }
        }

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
