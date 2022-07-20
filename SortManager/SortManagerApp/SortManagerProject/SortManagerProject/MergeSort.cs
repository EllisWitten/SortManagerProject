using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerProject
{
    public class MergeSort
    {
        public static int[] MergeSortRecursive(int[] input)
        {
            if (input.Length == 1)
                return input;

            int midpoint = (input.Length / 2);
            int[] left = new int[midpoint];
            
            for (int i = 0; i < midpoint; i++)
                left[i] = input[i];

            int[] right = new int[midpoint];
            for (int i = midpoint; i < input.Length; i++)
                right[i] = input[i];
        }

        private static void Merge(int[] input, int left, int m, int right)
        {

        }
    }
}
