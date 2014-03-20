using NUnit.Framework;
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

        [TestCaseSource(typeof(TestCasesProvider.FindFirst), "All__TestCases")]
        public int FindIn_Test(Case<char> @case)
        {
            return _finderFactory.CreateFrom(@case.Pattern)
                                 .FindIn(@case.Sequence);   
        }

        [TestCaseSource(typeof(TestCasesProvider.FindLast), "All__TestCases")]
        public int FindLastIn_Test(Case<char> @case)
        {
            return _finderFactory.CreateFrom(@case.Pattern)
                                 .FindLastIn(@case.Sequence);   
        }

        [TestCaseSource(typeof(TestCasesProvider.FindAll), "All__TestCases")]
        public IEnumerable<int> FindAllIn_Test(Case<char> @case)
        {
            return _finderFactory.CreateFrom(@case.Pattern)
                                 .FindAllIn(@case.Sequence);   
        }
    }
}
