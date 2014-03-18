﻿using System;
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
                          .Select((v, i) => new { v, i })
                          .ToDictionary(o => o.v, o => o.i);

            _dfa = new int[_abc.Count, pattern.Length]; 

            _dfa[0, 0] = 1;

            for (int i = 0, j = 1; j < pattern.Length; i = _dfa[AbcIndex(pattern[j++]), i])
            {
                for (int c = 0; c < _abc.Count; c++)
                    _dfa[c, j] = _dfa[c, i];
                _dfa[AbcIndex(pattern[j]), j] = j + 1;
            }
        }

        public int FindIn(IEnumerable<T> sequence)
        {
            var state = 0;
            foreach (var o in sequence.Select(AbcIndex)
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
            throw new NotImplementedException();
        }

        public IEnumerable<int> FindAllIn(IEnumerable<T> sequence)
        {
            throw new NotImplementedException();
        }

        public bool ExistsIn(IEnumerable<T> sequence)
        {
            using (var e = sequence.Select(AbcIndex)
                                   .GetEnumerator())
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

        private int AbcIndex(T c)
        {
            return _abc[c];
        }
    }
}
