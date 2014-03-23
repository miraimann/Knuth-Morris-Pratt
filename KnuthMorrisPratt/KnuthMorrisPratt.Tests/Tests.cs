using NUnit.Framework;
using SSCases;
using System.Collections.Generic;

namespace KnuthMorrisPratt.Tests
{
    [TestFixture]
    public class Tests
    {
        private readonly IFinderFactory<char> _finderFactory =
                      new FinderFactory<char>();

        [TestCaseSource(typeof(AllCases), "ForExists")]
        public bool ExistsIn_Test(Case<char> @case)
        {
            return _finderFactory.CreateFrom(@case.Pattern)
                                 .ExistsIn(@case.Sequence);   
        }

        [TestCaseSource(typeof(AllCases), "ForFindFirst")]
        public int FindIn_Test(Case<char> @case)
        {
            return _finderFactory.CreateFrom(@case.Pattern)
                                 .FindIn(@case.Sequence);   
        }

        [TestCaseSource(typeof(AllCases), "ForFindLast")]
        public int FindLastIn_Test(Case<char> @case)
        {
            return _finderFactory.CreateFrom(@case.Pattern)
                                 .FindLastIn(@case.Sequence);   
        }

        [TestCaseSource(typeof(AllCases), "ForFindAll")]
        public IEnumerable<int> FindAllIn_Test(Case<char> @case)
        {
            return _finderFactory.CreateFrom(@case.Pattern)
                                 .FindAllIn(@case.Sequence);   
        }
    }
}
