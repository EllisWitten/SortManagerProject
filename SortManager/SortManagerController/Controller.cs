using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SortManagerModel;

namespace SortManagerController;

public enum Algorithms { MERGESORT }

public class Controller : ISort
{
    public Algorithms Algorithm { get; set; }

    public Controller(string sortMethod)
    {
        switch (sortMethod.ToLower())
        {
            case "mergesort":
                Algorithm = Algorithms.MERGESORT;
                break;
            default:
                throw new ArgumentOutOfRangeException("Sort algorithm is unrecognised");
        }
    }

    public int[] Sort(int[] input)
    {
        switch (Algorithm)
        {
            case Algorithms.MERGESORT:
                var _sorter = new SortManagerModel.
                // var _sorter = new 
                // return _sorter.Sort(input);
            default:
                throw new ArgumentException();
        }
    }


}
