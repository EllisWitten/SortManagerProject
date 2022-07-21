using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAndProperties
{
    public class Factorial
    {
        public static int Factorise(int n)
        {
            if (n == 1) return 1;
            
            return n *Factorise(n-1);
        }
    }
}
