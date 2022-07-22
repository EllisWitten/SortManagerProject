namespace SortManagerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = View.GetArr();
            int method = View.GetMethod();
            int[] sortedArr = View.RunMethod(array, method);
            //Console.WriteLine("Hello, World!");
        }
    }
}