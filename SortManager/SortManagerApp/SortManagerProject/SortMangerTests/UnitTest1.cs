namespace SortManagerTests;

using SortManagerProject;


public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GivenAOneELementArray_MergeSortReturnsTheArray()
    {
        int[] array = new int[](1);
        Assert.That(MergeSort.MergeSortRecursive(array), Is.EqualTo(array));
    }
}