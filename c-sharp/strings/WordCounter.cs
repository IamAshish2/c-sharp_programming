using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.strings
{
    internal class WordCounter
    {
        public static void Count(string str)
        {
            int wrdCtr = 1;

            foreach (char c in str)
            {
                if (c == ' ' || c == '\n' || c == '\t') wrdCtr++;
            }
            Console.WriteLine(wrdCtr);
        }
    }
}
