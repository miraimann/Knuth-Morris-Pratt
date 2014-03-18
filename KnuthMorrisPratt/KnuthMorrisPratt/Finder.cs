using System;
using System.Collections.Generic;
using System.Linq;

namespace KnuthMorrisPratt
{
    internal class Finder<T> : IFinder<T>
    {
        private readonly int[,] _dfa;
        private readonly Dictionary<T, int> _abc;

        private readonly int _startingState = 0;
        private readonly int _finalState;

        public Finder(IEnumerable<T> word)
        {
            var pattern = word as T[] ?? word.ToArray();

            _finalState = pattern.Length;

            _abc = pattern.Distinct()
                          .Select((v, i) => new { v, i })
                          .ToDictionary(o => o.v, o => o.i);

            _dfa = new int[_abc.Count, pattern.Length]; 

            _dfa[0, 0] = 1;

            for (int i = 0, j = 1; j < pattern.Length; i = _dfa[_abc[pattern[j++]], i])
            {
                for (int c = 0; c < _abc.Count; c++)
                    _dfa[c, j] = _dfa[c, i];
                _dfa[_abc[pattern[j]], j] = j + 1;
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
            using (var e = sequence.Select(c => _abc[c])
                                   .GetEnumerator())
            {
                int state = _startingState;
                while (e.MoveNext())
                {
                    state = _dfa[e.Current, state];
                    if (state == _finalState) return true;
                }

                return false;
            }
        }
    }
}
