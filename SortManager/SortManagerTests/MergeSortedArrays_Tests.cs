using System;
using System.Collections.Generic;
using System.Linq;
using SortManagerModel;

namespace SortManagerTests
{
    public class MergeSortedArrays_Tests
    {
        [Test] // 1.1
        public void GivenTwoEmptyArrays_MergeSortedArrays_ReturnsAnEmptyArray()
        {
            Assert.That(MergeSort.MergeSortedArrays(new int[] { }, new int[] { }), Is.EqualTo(new int[] { }));
        }

        [Test] // 1.2
        public void GivenOneEmptyAndOneSingleValuedArray_MergeSortedArrays_ReturnsAnArrayWithTheSingleValue()
        {
            Assert.That(MergeSort.MergeSortedArrays(new int[] { }, new int[] { 1 }), Is.EqualTo(new int[] { 1 }));
        }

        [TestCaseSource(nameof(singleValueArrays))] // 1.3
        public void GivenTwoSingleValueArrays_MergeSortedArrays_ReturnsAnArrayWithBothValuesInOrder(int[] arrayOne, int[] arrayTwo, int[] expectedResult)
        {
            Assert.That(MergeSort.MergeSortedArrays(arrayOne, arrayTwo), Is.EqualTo(expectedResult));
        }

        static object[] singleValueArrays =
        {
            // In order
            new object [] {new int[] { 1 }, new int[] { 2 }, new int[] { 1, 2 } },
            // Out of order
            new object [] {new int[] { 2 }, new int[] { 1 }, new int[] { 1, 2 } },
        };

        [TestCaseSource(nameof(singleDoubleValueArrays))] // 1.4
        public void GivenASingleValueArrayAndATwoValueArray_MergeSortedArrays_ReturnsAnArrayWithAllThreeValuesInOrder(int[] arrayOne, int[] arrayTwo, int[] expectedResult)
        {
            Assert.That(MergeSort.MergeSortedArrays(arrayOne, arrayTwo), Is.EqualTo(expectedResult));
        }

        static object[] singleDoubleValueArrays =
        {
            // All valid permutations
            new object [] {new int[] { 1 }, new int[] { 2, 3 }, new int[] { 1, 2, 3 } },
            new object [] {new int[] { 2 }, new int[] { 1, 3 }, new int[] { 1, 2, 3 } },
            new object [] {new int[] { 3 }, new int[] { 1, 2 }, new int[] { 1, 2, 3 } },
            new object [] {new int[] { 1, 2 }, new int[] { 3 }, new int[] { 1, 2, 3 } },
            new object [] {new int[] { 1, 3 }, new int[] { 2 }, new int[] { 1, 2, 3 } },
            new object [] {new int[] { 2, 3 }, new int[] { 1 }, new int[] { 1, 2, 3 } },
        };

        [TestCaseSource(nameof(doubleValueArrays))] // 1.5
        public void GivenTwoTwoValueArrays_MergeSortedArrays_ReturnsAnArrayWithAllFourValuesInOrder(int[] arrayOne, int[] arrayTwo, int[] expectedResult)
        {
            Assert.That(MergeSort.MergeSortedArrays(arrayOne, arrayTwo), Is.EqualTo(expectedResult));
        }

        static object[] doubleValueArrays =
        {
            // Lower values first
            new object [] {new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 1, 2, 3, 4 } },
            // Higher values first
            new object [] {new int[] { 3, 4 }, new int[] { 1, 2 }, new int[] { 1, 2, 3, 4 } },
            // Interleaved mid interval, low first
            new object [] {new int[] { 1, 3 }, new int[] { 2, 4 }, new int[] { 1, 2, 3, 4 } },
            // Interleaved mid interval, hight first
            new object [] {new int[] { 2, 4 }, new int[] { 1, 3 }, new int[] { 1, 2, 3, 4 } },
            // Interleaved high interval first
            new object [] {new int[] { 1, 4 }, new int[] { 2, 3 }, new int[] { 1, 2, 3, 4 } },
            // Interleaved high interval second
            new object [] {new int[] { 2, 3 }, new int[] { 1, 4 }, new int[] { 1, 2, 3, 4 } },
        };
    }
}
