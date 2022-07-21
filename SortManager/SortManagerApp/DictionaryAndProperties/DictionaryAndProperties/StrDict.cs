using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAndProperties
{
    public class StrDict
    {
            public static Dictionary<char, int> LetterCount(string input)
            {
                Dictionary<char, int> result = new Dictionary<char, int>();

                foreach (char c in input)
                {
                    if (result.ContainsKey(c))
                    {
                        result[c]++;
                    }
                    else
                    {
                        result.Add(c, 1);
                    }
                }
                return result;
             }
     }
}
