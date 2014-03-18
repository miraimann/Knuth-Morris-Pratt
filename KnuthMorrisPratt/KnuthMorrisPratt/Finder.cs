using System;
using System.Collections.Generic;
using System.Linq;

namespace KnuthMorrisPratt
{
    internal class Finder<T> : IFinder<T>
    {
        private readonly T[] _pattern;
        private readonly int[,] _dfa;

        public Finder(IEnumerable<T> word)
        {
            _pattern = word as T[] ?? word.ToArray();
            
            var abc = _pattern.Distinct().ToList();

            _dfa = new int[abc.Count, _pattern.Length]; 

            _dfa[0, 0] = 1;

            for (int x = 0, j = 1; j < _pattern.Length; x = _dfa[abc.IndexOf(_pattern[j++]), x])
            {
                for (int c = 0; c < abc.Count; c++)
                    _dfa[c, j] = _dfa[c, x];
                _dfa[abc.IndexOf(_pattern[j]), j] = j + 1;
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
