using System;
using System.Collections.Generic;

namespace Roslyn.Utilities
{
    public static partial class EnumerableExtensions
    {
        private class ComparisonComparer<T> : Comparer<T>
        {
            private readonly Comparison<T> _compare;

            public ComparisonComparer(Comparison<T> compare)
            {
                _compare = compare;
            }

            public override int Compare(T x, T y)
            {
                return _compare(x, y);
            }
        }
    }
}