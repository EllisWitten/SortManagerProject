using SortManagerController;

namespace SortManagerModel
{
    public class MergeSort : ISort
    {
        public int[] Sort(int[] inputArray)
        {
            if (inputArray.Length <= 0)
            {
                throw new ArgumentException("Input must contain at least one element");
            }

            int[] leftArray;
            int[] rightArray;
            int[] result = new int[inputArray.Length];

            if (inputArray.Length <= 1)
            {
                return inputArray;
            }

            int midPoint = inputArray.Length / 2;

            leftArray = new int[midPoint];

            if (inputArray.Length % 2 == 0) // If the input array has an even number of elements, then both left and right arrays will have the same number of elements.
            {
                rightArray = new int[midPoint];
            }
            else
            {
                rightArray = new int[midPoint + 1];
            }

            for (int i = 0; i < midPoint; i++)
            {
                leftArray[i] = inputArray[i];
            }

            int x = 0;

            for (int i = midPoint; i < inputArray.Length; i++)
            {
                rightArray[x] = inputArray[i];
                x++;
            }

            leftArray = Sort(leftArray);
            rightArray = Sort(rightArray);

            result = MergeSortedArrays(leftArray, rightArray);

            return result;
        }

        public static int[] MergeSortedArrays(int[] leftArray, int[] rightArray)
        {
            int resultLength = rightArray.Length + leftArray.Length;
            int[] result = new int[resultLength];

            int leftIndex = 0;
            int rightIndex = 0;
            int resultIndex = 0;

            while (leftIndex < leftArray.Length || rightIndex < rightArray.Length)
            {
                if (leftIndex < leftArray.Length && rightIndex < rightArray.Length) // If both arrays have elements.
                {
                    if (leftArray[leftIndex] <= rightArray[rightIndex])
                    {
                        result[resultIndex] = leftArray[leftIndex];
                        leftIndex++;
                        resultIndex++;
                    }
                    else
                    {
                        result[resultIndex] = rightArray[rightIndex];
                        rightIndex++;
                        resultIndex++;
                    }
                }
                else if (leftIndex < leftArray.Length) // If the left array still has elements.
                {
                    result[resultIndex] = leftArray[leftIndex];
                    leftIndex++;
                    resultIndex++;
                }
                else if (rightIndex < rightArray.Length) // If the right array still has elements.
                {
                    result[resultIndex] = rightArray[rightIndex];
                    rightIndex++;
                    resultIndex++;
                }
            }

            return result;
        }
    }
}
