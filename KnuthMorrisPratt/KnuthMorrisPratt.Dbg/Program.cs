using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnuthMorrisPratt.Dbg
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new FinderFactory<char>().CreateFrom("aaxaayaaxaaz");
        }
    }
}
