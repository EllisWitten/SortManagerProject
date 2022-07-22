using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAndProperties
{
    internal class View
    {
        public static int[] GetArr()
        {
            Console.WriteLine("Welcome to SortManager.");
            Console.WriteLine("Do you have an Array you want to enter, Y or N");
            var UserAns = Console.ReadLine();

            if (UserAns.ToUpper() == "Y")
            {
                Console.WriteLine("enter your array sperated by commas");
                string strInput = Console.ReadLine();

                if (strInput != null || strInput.Length < 3)
                {
                    throw new ArgumentNullException();
                }

                int[] intArray = Array.ConvertAll(strInput.Split(','), s => int.Parse(s));

                foreach (var num in intArray)
                {
                    Console.WriteLine(num);
                }

                return intArray;
            }
            else if (UserAns.ToUpper() == "N")
            {
                Console.WriteLine("How long do you want the random array to be?");
                int length = Convert.ToInt32(Console.ReadLine());
                return randomArr(length);
            }
            else
            {
                throw new Exception();
            }
        }

        public static int[] RunMethod(int[] array, int method)
        {
            /*Controller _controller = new Controller("mergesort");
            int[] result = _controller.Sort(input);
            return result;*/
            Console.WriteLine("Running RunMethod");
            return (array);
        }

        public static int[] randomArr(int length)
        {
            int[] array = new int[length];
            Random r = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = r.Next(1, 101);
            }
            foreach(var num in array)
            {
                Console.WriteLine(num);
            }
            return array;
        }

        public static int GetMethod()
        {
            Console.WriteLine("Select your method by inputting a number");
            Console.WriteLine("1) Method1\n2) Method2 3)\nMethod3");
            int method = Convert.ToInt32(Console.ReadLine());

            if (method > 0 && method <= 3)
            {
                return method;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
