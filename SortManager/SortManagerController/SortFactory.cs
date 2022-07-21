using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SortManagerModel;
namespace SortManagerController
{
    public class SortFactory
    {
        public static ISort GetInstance(registeredSortMethods selectedSortMethod)
        {
            switch (selectedSortMethod)
            {
                case registeredSortMethods.MERGESORT:
                    return new MergeSort();
                default:
                    return null;
            }
        }
    }
}
