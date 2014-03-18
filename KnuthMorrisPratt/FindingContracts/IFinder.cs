using System.Collections.Generic;

namespace System
{
    public interface IFinder<in T>
    {
        int FindIn(IEnumerable<T> sequence);

        int FindLastIn(IEnumerable<T> sequence);

        IEnumerable<int> FindAllIn(IEnumerable<T> sequence);

        bool ExistsIn(IEnumerable<T> sequence);
    }
}
