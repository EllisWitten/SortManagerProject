using SortManagerModel;
namespace SortManagerTests
{
    public class MergeSortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenAOneElementArray_MergeSort_ReturnsTheArray()
        {
            int[] testArray = new int[] { 1 };
            Assert.That(MergeSort.MergeSortRecursive(testArray), Is.EqualTo(testArray));
        }

        [Test]
        public void GivenATwoElementArray_MergeSort_ReturnsTheArray()
        {
            int[] testArray = new int[] { 1, 2 };
            Assert.That(MergeSort.MergeSortRecursive(testArray), Is.EqualTo(testArray));
        }
    }
}