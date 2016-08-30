using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinerySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 1, 16, 9, 2 };
            BineryTree<int> tree = new BineryTree<int>();
            tree.Add(array);

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Array - {0}: {1}  \t\t", i, BinerySearch.IsExist(array, i));
                Console.WriteLine("Tree - {0}: {1}", i, BinerySearch.IsExist(tree, i));
            }
            Console.ReadLine();
        }
    }
}
