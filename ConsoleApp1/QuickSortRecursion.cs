using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class QuickSortRecursion
    {
        int[] data = new int [12] { 12, -1, 4, 100, 9, 7, 160, 16, 8, 9, 36,25};
        int l = 0;
        int r = 11;
        public static void IntArrayQuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    exchange(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                IntArrayQuickSort(data, l, j);
            if (i < r)
                IntArrayQuickSort(data, i, r);
        }

        public static void IntArrayQuickSort(int[] data)
        {
            IntArrayQuickSort(data, 0, data.Length - 1);
        }

        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
    }
}
