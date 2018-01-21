using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateEvaluatorNamespace
{
    public static class PredicateEvaluator
    {
        public static Func<IComparable, IComparable, bool> IncreasingPredicate = (x, y) => { return x.CompareTo(y) <= 0; };
        public static Func<IComparable, IComparable, bool> DecreasingPredicate = (x, y) => { return x.CompareTo(y) >= 0; };
        public static Func<IComparable, IComparable, bool> StrictlyIncreasingPredicate = (x, y) => { return x.CompareTo(y) < 0; };
        public static Func<IComparable, IComparable, bool> StrictlyDecreasingPredicate = (x, y) => { return x.CompareTo(y) > 0; };



        public static bool EvaluateSetAgainstPredicate<T>(List<T> list, Func<IComparable, IComparable, bool> predicate) where T : IComparable
        {
            return list.Zip(list.Skip(1), (first, second) => predicate(first, second)).All(result => result == true);
        }
    }
}
