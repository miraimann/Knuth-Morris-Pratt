using System;
using System.Collections.Generic;
using System.Linq;

namespace KnuthMorrisPratt
{
    internal class Finder<T> : IFinder<T>
    {
        private readonly int[,] _dfa;
        private readonly Dictionary<T, int> _abc;
        private readonly int _finalState;

        public Finder(IEnumerable<T> word)
        {
            var pattern = word as T[] ?? word.ToArray();

            _finalState = pattern.Length;

            _abc = pattern.Distinct()
                          .Select((value, index) => new { value, index })
                          .ToDictionary(o => o.value, o => o.index);

            _dfa = new int[_abc.Count, pattern.Length + 1]; 

            _dfa[0, 0] = 1;

            int i = 0, j = 1;
            while (j < pattern.Length)
            {
                Copy(from: i, to: j);

                _dfa[_abc[pattern[j]], j] = j + 1;

                i = _dfa[_abc[pattern[j++]], i];
            }
            

            Copy(from: i, to: j);
        }

        public int FindIn(IEnumerable<T> sequence)
        {
            var state = 0;
            foreach (var o in SelectAbcIndexesFrom(sequence)
                                        .Select((c, i) => new { c, i }))
            {
                state = _dfa[o.c, state];
                if (state == _finalState)
                    return o.i - _finalState + 1;
            }

            return -1;
        }

        public int FindLastIn(IEnumerable<T> sequence)
        {
            var last = -1;
            var state = 0;
            foreach (var o in SelectAbcIndexesFrom(sequence)
                                        .Select((c, i) => new { c, i }))
            {
                state = _dfa[o.c, state];
                if (state == _finalState)
                    last = o.i - _finalState + 1;
            }

            return last;
        }

        public IEnumerable<int> FindAllIn(IEnumerable<T> sequence)
        {
            var state = 0;
            foreach (var o in SelectAbcIndexesFrom(sequence)
                                        .Select((c, i) => new { c, i }))
            {
                state = _dfa[o.c, state];
                if (state == _finalState)
                    yield return o.i - _finalState + 1;
            }
        }

        public bool ExistsIn(IEnumerable<T> sequence)
        {
            using (var e = SelectAbcIndexesFrom(sequence).GetEnumerator())
            {
                int state = 0;
                while (e.MoveNext())
                {
                    state = _dfa[e.Current, state];
                    if (state == _finalState) return true;
                }

                return false;
            }
        }

        private void Copy(int from, int to)
        {
            for (int c = 0; c < _abc.Count; c++)
                _dfa[c, to] = _dfa[c, from];
        }

        private IEnumerable<int> SelectAbcIndexesFrom(IEnumerable<T> sequence)
        {
            return sequence.Select(c => _abc[c]);
        }
    }
}
