using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAndProperties;

//public class MergeSort
//{
//    public static void ArrSetUp()
//    {
//        var unsorted = new int[16];
//        var random = new Random();

//        for (int i = 0; i < unsorted.Length; i++)
//        {
//            unsorted[i] = random.Next(1,101);

//        }

//        Console.WriteLine("unsorted array");
//        DisplayArray(unsorted);

//        ArrMerge(unsorted);

//        Console.WriteLine("sorted array");
//        DisplayArray(unsorted);
//    }

//    private static void ArrMerge(Span<int> unsorted)
//    {
//        var m = unsorted.Length / 2;

//        if ( unsorted.Length > 1)
//        {
//            ArrMerge(unsorted.Slice(0, m ));
//            ArrMerge(unsorted.Slice(m ));
//            Merge(unsorted, m);
//        }
        
//    }

//    private static void Merge(Span<int> result, int rhStart)
//    {
//        var input = result.ToArray();
//        var lhs = 0;
//        var rhs = rhStart;
//        var index = 0;

//        while (lhs < rhStart && rhs < input.Length)
//        {

//            if (input[lhs] <= input[rhs])
//            {
//                result[index] = input[lhs];
//                lhs++;
//            }
//            else
//            {
//                result[index] = input[rhs];
//                rhs++;
//            }
//            index++;
//         }

//        while (lhs < rhStart)
//        {
//            result[index] = input[lhs];
//            lhs++;
//            index++;
//        }
//        while (rhs < input.Length)
//        {
//            result[index] = input[rhs];
//            rhs++;
//            index++;
//        }
//    }

//    private static void DisplayArray(int[] unsorted)
//    {
//        var text = string.Join(',', unsorted);
//        Console.WriteLine(text);
//    }
//}
