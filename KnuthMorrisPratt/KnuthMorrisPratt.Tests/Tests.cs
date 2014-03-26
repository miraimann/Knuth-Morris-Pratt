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
        public bool ExistsIn_Test(string pattern, string sequence)
        {
            return _finderFactory.CreateFrom(pattern)
                                 .ExistsIn(sequence);   
        }

        [TestCaseSource(typeof(AllCases), "ForFindFirst")]
        public int FindIn_Test(string pattern, string sequence)
        {
            return _finderFactory.CreateFrom(pattern)
                                 .FindIn(sequence);   
        }

        [TestCaseSource(typeof(AllCases), "ForFindLast")]
        public int FindLastIn_Test(string pattern, string sequence)
        {
            return _finderFactory.CreateFrom(pattern)
                                 .FindLastIn(sequence);   
        }

        [TestCaseSource(typeof(AllCases), "ForFindAll")]
        public IEnumerable<int> FindAllIn_Test(string pattern, string sequence)
        {
            return _finderFactory.CreateFrom(pattern)
                                 .FindAllIn(sequence);   
        }
    }
}
