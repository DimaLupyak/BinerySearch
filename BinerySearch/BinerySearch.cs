using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinerySearch
{
    public static class BinerySearch
    {
        public static bool IsExist<T>(T[] array, T item) where T : IComparable
        {
            Array.Sort<T>(array);
            int left = 0;
            int right = array.Length;
            while (left < right)
            {
                int middle = (left + right) / 2;
                if (array[middle].CompareTo(item) == 0)
                    return true;
                else if (array[middle].CompareTo(item) < 0)
                    left = middle+1;
                else
                    right = middle;
            }
            return false;
        }
        public static bool IsExist<T>(BineryTree<T> tree, T item) where T : IComparable
        {
            return tree.IsExist(item);
        }
    }
}
