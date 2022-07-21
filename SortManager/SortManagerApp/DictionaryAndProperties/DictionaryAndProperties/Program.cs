namespace DictionaryAndProperties;

public class Program
{
    static void Main(string[] args)
    {
        /*var dict = StrDict.LetterCount("hello");
        
        foreach(object kvp in dict)
        {
            Console.WriteLine(kvp.ToString());
        }*/

        // Factorial.Factorise(5);

        // MergeSort.ArrSetUp();

        int[] array = View.GetArr();
        int method = View.GetMethod();
        int[] sortedArr = View.RunMethod(array, method);

    }
}

