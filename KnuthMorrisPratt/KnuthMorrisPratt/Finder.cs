using System;
using System.Collections.Generic;
using System.Linq;

namespace KnuthMorrisPratt
{
    internal class Finder<T> : IFinder<T>
    {
        public const int NotFound = -1;
        private const int StartingState = 0;

        private readonly int[,] _dfa;
        private readonly Dictionary<T, int> _abc;
        private readonly int _finalState;

        public Finder(IEnumerable<T> pattern)
        {
            var p = pattern as T[] ?? pattern.ToArray();

            _finalState = p.Length;

            _abc = p.Distinct()
                    .Select((value, index) => new { value, index })
                    .ToDictionary(o => o.value, o => o.index);

            _dfa = new int[_abc.Count, p.Length + 1];

            _dfa[0, StartingState] = 1;

            int i = 0, j = 1;
            while (j < p.Length)
            {
                Copy(from: i, to: j);

                _dfa[_abc[p[j]], j] = j + 1;

                i = _dfa[_abc[p[j++]], i];
            }
            
            Copy(from: i, to: j);
        }

        public int FindIn(IEnumerable<T> sequence)
        {
            int state = StartingState, i = 0;
            foreach (var c in sequence)
            {
                state = GoNext(c, state);
                if (state == _finalState)
                    return i - _finalState + 1;
                ++i;
            }

            return NotFound;
        }

        public int FindLastIn(IEnumerable<T> sequence)
        {
            int rusult = NotFound,
                state = StartingState,
                i = 0;

            foreach (var c in sequence)
            {
                state = GoNext(c, state);
                if (state == _finalState)
                    rusult = i - _finalState + 1;
                ++i;
            }

            return rusult;
        }

        public IEnumerable<int> FindAllIn(IEnumerable<T> sequence)
        {
            int state = StartingState, i = 0;
            foreach (var c in sequence)
            {
                state = GoNext(c, state);
                if (state == _finalState)
                    yield return i++ - _finalState + 1;
            }
        }

        public bool ExistsIn(IEnumerable<T> sequence)
        {
            int state = StartingState;
            foreach (var c in sequence)
            {
                state = GoNext(c, state);
                if (state == _finalState) return true;     
            }

            return false;
        }

        private int GoNext(T c, int state)
        {
            return _abc.ContainsKey(c) ? _dfa[_abc[c], state] 
                                       : StartingState;
        }

        private void Copy(int from, int to)
        {
            for (int c = 0; c < _abc.Count; c++)
                _dfa[c, to] = _dfa[c, from];
        }
    }
}
