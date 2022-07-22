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

        [TestCaseSource(typeof(TestData), nameof(TestData.singleValueArrays))] // 1.3
        public void GivenTwoSingleValueArrays_MergeSortedArrays_ReturnsAnArrayWithBothValuesInOrder(int[] arrayOne, int[] arrayTwo, int[] expectedResult)
        {
            Assert.That(MergeSort.MergeSortedArrays(arrayOne, arrayTwo), Is.EqualTo(expectedResult));
        }


        [TestCaseSource(typeof(TestData), nameof(TestData.singleDoubleValueArrays))] // 1.4
        public void GivenASingleValueArrayAndATwoValueArray_MergeSortedArrays_ReturnsAnArrayWithAllThreeValuesInOrder(int[] arrayOne, int[] arrayTwo, int[] expectedResult)
        {
            Assert.That(MergeSort.MergeSortedArrays(arrayOne, arrayTwo), Is.EqualTo(expectedResult));
        }


        [TestCaseSource(typeof(TestData), nameof(TestData.doubleValueArrays))] // 1.5
        public void GivenTwoTwoValueArrays_MergeSortedArrays_ReturnsAnArrayWithAllFourValuesInOrder(int[] arrayOne, int[] arrayTwo, int[] expectedResult)
        {
            Assert.That(MergeSort.MergeSortedArrays(arrayOne, arrayTwo), Is.EqualTo(expectedResult));
        }
    }
}
