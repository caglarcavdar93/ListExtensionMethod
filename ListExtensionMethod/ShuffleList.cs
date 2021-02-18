using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExtensionMethod
{
    public static class ShuffleList
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            if (list.Count != 0)
            {
                var rnd = new Random();
                var newList = list.OrderBy(x => rnd.Next()).ToList();
                for (var i = 0; i < list.Count; i++)
                {
                    list[i] = newList[i];
                }
            }
        }
    }
}
