namespace SortManagerModel;

public class MergeSort
{
    public static int[] MergeSortRecursive(int[] input)
    {
        if (input.Length == 1) return input;

        int midpoint = (input.Length / 2);
        int[] left = new int[midpoint];
        for (int i = 0; i < midpoint; i++)
            left[i] = input[i];

        int[] right = new int[input.Length - midpoint];
        for (int i = midpoint; i < input.Length; i++)
            right[i] = input[i];

        int[] lResult = MergeSortRecursive(left);
        int[] rResult = MergeSortRecursive(right);

        int[] finalResult = MergeSortedArrays(lResult, rResult);

        return finalResult;
    }

    public static int[] MergeSortedArrays(int[] arrayOne, int[] arrayTwo)
    {
        // JOIN THESE TWO ARRAYS INTO ONE
        return new int[] { -1 };
    }
}