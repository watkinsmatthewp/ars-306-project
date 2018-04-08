using System;
using System.Collections.Generic;
using System.Text;

namespace Dumbposer.Extensions
{
    public static class RandomExtensions
    {
        public static bool ChanceOfOneIn(this Random random, int total) => random.ChanceOf(1, total);
        public static bool ChanceOf(this Random random, int possible, int total) => random.Chance(possible / (double)total);
        public static bool Chance(this Random random, double chance) => random.NextDouble() <= chance;
        public static T PickOne<T>(this Random random, IList<T> collection) => collection[random.Next(0, collection.Count)];
    }
}
