using System;
using System.Collections.Generic;

namespace CountingSortCSharp
{
    public class Sorting
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> list, int k, Func<T, int> func)
        {
            List<T> sortedList = new List<T>();
            List<List<T>> C = new List<List<T>>();

            for (int i = 0; i < k; i++)
            {
                C.Add(new List<T>());
            }

            foreach (var i in list)
            {
                int pos = func(i);
                C[pos].Add(i);
            }

            for (int j = 0; j < C.Count; j++)
            {
                for (int i = 0; i < C[j].Count; i++)
                {
                    sortedList.Add(C[j][i]);
                }
            }

            return sortedList;
        }

    }
}
