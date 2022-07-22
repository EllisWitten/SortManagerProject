using SortManagerModel;

namespace SortManagerTests
{
    public class MergeSort_Tests
    {        
        private MergeSort _sorter = new MergeSort();

        [TestCaseSource(typeof(TestData), nameof(TestData.SadCases))]
        public void GivenInValidSortingInput_BubbleSort_Throws(int[] input)
        {
            Assert.That(() => _sorter.Sort(input), Throws.TypeOf<ArgumentException>().With.Message.Contains("Input must contain at least one element"));
        }
        
        [TestCaseSource(typeof(TestData), nameof(TestData.HappyCases))]
        public void GivenValidSortingInput_BubbleSort_ReturnsExpectedResult(int[] input, int[] expectedResult)
        {
            Assert.That(_sorter.Sort(input), Is.EquivalentTo(expectedResult).With.Ordered.Ascending);
        }
    }
}
