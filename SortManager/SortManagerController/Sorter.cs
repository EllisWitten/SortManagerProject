namespace SortManagerController
{
    public interface ISort
    {
        int[] Sort(int[] input);
    }

    public abstract class Sorter : ISort
    {
        public abstract int[] Sort(int[] input);
    }

}