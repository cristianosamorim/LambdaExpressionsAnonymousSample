using System.Collections.Generic;
using System.Linq;
using static System.Linq.ParallelEnumerable;

namespace LambdaExpressionsAnonymousSample
{
    public static class MultpilicationFormatter
    {
        static int counter;

        static string Counter(int val) => $"{++counter} x 2 = {val}";

        public static List<string> Format(List<int> list)
            => list.AsParallel()
                .Select(Extensions.MultiplyBy2)
                .Zip(Range(1, list.Count), (val, counter) => $"{counter} x 2 = {val}")
                .ToList();
    }
}
