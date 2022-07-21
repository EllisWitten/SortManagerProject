using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace SortManagerController
{
    public enum registeredSortMethods { MERGESORT }
    public class Controller : ISort
    {
        public registeredSortMethods selectedSortMethod { get; set; }

        public Controller(string sortMethod)
        {
            switch (sortMethod.ToLower())
            {
                case "mergesort":
                    selectedSortMethod = registeredSortMethods.MERGESORT;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Sort algorithm is unrecognised");
            }
        }

        public int[] Sort(int[] input)
        {
            Stopwatch executionTime = new Stopwatch();
            var _sorter = SortFactory.GetInstance(selectedSortMethod);
            executionTime.Start();
            var sortedArray = _sorter.Sort(input);
            executionTime.Stop();
            var timeToSort = executionTime.ElapsedMilliseconds;
            // Call a method in View to display the elapsed time
            return sortedArray;
        }
    }
}
