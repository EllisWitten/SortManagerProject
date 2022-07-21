namespace SortManagerTests
{
    public class TestData
    {
        #region MergeSort Test Data
        public static object[] SadCases =
        {
            new object[] { new int[] { } }
        };

        public static object[] HappyCases =
        {
            // single element array
            new int[][] { new int[]  { 1 }, new int[] { 1 } },
            // array of all 1s
            new int[][] { new int[]  { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 } },
            // array of all -1s
            new int[][] { new int[]  { -1, -1, -1, -1, -1 }, new int[] { -1, -1, -1, -1, -1 } },
            // Random order
            new int[][] { new int[]  { 5, 1, 3, 2, 4 }, new int[] { 1, 2, 3, 4, 5 } },
            // almost sorted
            new int[][] { new int[]  { 1, 3, 2, 4, 6, 5 }, new int[] { 1, 2, 3, 4, 5, 6 } },
            // inverse sorted
            new int[][] { new int[]  { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 } },
            // few unique values
            new int[][] { new int[]  { 1, 2, 3, 3, 1, 2 }, new int[] { 1, 1, 2, 2, 3, 3 } },
        };
        #endregion

        #region MergeSortArrays Test Data
        public static object[] singleValueArrays =
        {
            // In order
            new int[][] {new int[] { 1 }, new int[] { 2 }, new int[] { 1, 2 } },
            // Out of order
            new int[][] {new int[] { 2 }, new int[] { 1 }, new int[] { 1, 2 } },
        };

        public static object[] singleDoubleValueArrays =
        {
            // All valid permutations
            new int[][] {new int[] { 1 }, new int[] { 2, 3 }, new int[] { 1, 2, 3 } },
            new int[][] {new int[] { 2 }, new int[] { 1, 3 }, new int[] { 1, 2, 3 } },
            new int[][] {new int[] { 3 }, new int[] { 1, 2 }, new int[] { 1, 2, 3 } },
            new int[][] {new int[] { 1, 2 }, new int[] { 3 }, new int[] { 1, 2, 3 } },
            new int[][] {new int[] { 1, 3 }, new int[] { 2 }, new int[] { 1, 2, 3 } },
            new int[][] {new int[] { 2, 3 }, new int[] { 1 }, new int[] { 1, 2, 3 } },
        };

        public static object[] doubleValueArrays =
        {
            // Lower values first
            new int[][] {new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 1, 2, 3, 4 } },
            // Higher values first
            new int[][] {new int[] { 3, 4 }, new int[] { 1, 2 }, new int[] { 1, 2, 3, 4 } },
            // Interleaved mid interval, low first
            new int[][] {new int[] { 1, 3 }, new int[] { 2, 4 }, new int[] { 1, 2, 3, 4 } },
            // Interleaved mid interval, hight first
            new int[][] {new int[] { 2, 4 }, new int[] { 1, 3 }, new int[] { 1, 2, 3, 4 } },
            // Interleaved high interval first
            new int[][] {new int[] { 1, 4 }, new int[] { 2, 3 }, new int[] { 1, 2, 3, 4 } },
            // Interleaved high interval second
            new int[][] {new int[] { 2, 3 }, new int[] { 1, 4 }, new int[] { 1, 2, 3, 4 } },
        };
        #endregion
    }
}
