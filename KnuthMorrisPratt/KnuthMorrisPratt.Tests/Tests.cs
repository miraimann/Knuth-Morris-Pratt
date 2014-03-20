﻿using NUnit.Framework;
using StringSearch;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnuthMorrisPratt.Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly IFinderFactory<char> _finderFactory =
                      new FinderFactory<char>();

        [TestCaseSource(typeof(TestCasesProvider.Exists), "All__TestCases")]
        public bool ExistsIn_Test(Case<char> @case)
        {
            return _finderFactory.CreateFrom(@case.Pattern)
                                 .ExistsIn(@case.Sequence);   
        }

        public int FindIn_Test()
        {
            throw new NotImplementedException();
        }

        public int FindLastIn_Test()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<int> FindAllIn_Test()
        {
            throw new NotImplementedException();
        }

        private static class A
        {

        }
    }
}
