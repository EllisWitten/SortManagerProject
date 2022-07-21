using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var _sorter = SortFactory.GetInstance(selectedSortMethod);
            return _sorter.Sort(input);
        }
    }
}
