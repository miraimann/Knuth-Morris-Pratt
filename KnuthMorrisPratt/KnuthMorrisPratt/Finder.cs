using System;
using System.Collections.Generic;
using System.Linq;

namespace KnuthMorrisPratt
{
    internal class Finder<T> : IFinder<T>
    {
        public const int NotFound = -1;
        private const int CharacterThatIsMissingInThePattern = -1;
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
            var state = StartingState;
            foreach (var o in SelectAbcIndexesFrom(sequence)
                                        .Select((c, i) => new { c, i }))
            {
                state = GoNext(o.c, state);
                if (state == _finalState)
                    return o.i - _finalState + 1;
            }

            return NotFound;
        }

        public int FindLastIn(IEnumerable<T> sequence)
        {
            var rusult = NotFound;
            var state = StartingState;
            foreach (var o in SelectAbcIndexesFrom(sequence)
                                        .Select((c, i) => new { c, i }))
            {
                state = GoNext(o.c, state);
                if (state == _finalState)
                    rusult = o.i - _finalState + 1;
            }

            return rusult;
        }

        public IEnumerable<int> FindAllIn(IEnumerable<T> sequence)
        {
            var state = StartingState;
            foreach (var o in SelectAbcIndexesFrom(sequence)
                                        .Select((c, i) => new { c, i }))
            {
                state = GoNext(o.c, state);
                if (state == _finalState)
                    yield return o.i - _finalState + 1;
            }
        }

        public bool ExistsIn(IEnumerable<T> sequence)
        {
            using (var e = SelectAbcIndexesFrom(sequence).GetEnumerator())
            {
                int state = StartingState;
                while (e.MoveNext())
                {
                    state = GoNext(e.Current, state);
                    if (state == _finalState) return true;
                }

                return false;
            }
        }

        private int GoNext(int c, int state)
        {
            return c == CharacterThatIsMissingInThePattern 
                      ? StartingState 
                      : _dfa[c, state];
        }

        private void Copy(int from, int to)
        {
            for (int c = 0; c < _abc.Count; c++)
                _dfa[c, to] = _dfa[c, from];
        }

        private IEnumerable<int> SelectAbcIndexesFrom(IEnumerable<T> sequence)
        {
            return sequence.Select(c => _abc.ContainsKey(c) ? _abc[c] : CharacterThatIsMissingInThePattern);
        }
    }
}
