using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.strings
{
    //Write a program in C# Sharp to find the number of times a substring appears in a given string.
    public class CountSubString
    {
        public static void countString(string str,string sub)
        {
            int subLen = sub.Length;
            int ctr = 0;
            int start = 0;
            int idx = -1;

            while(start != -1)
            {
                 start = str.IndexOf(sub,idx + 1);
                if(start != -1)
                {
                    ctr++;
                    idx = start;
                }
                   
            }

            Console.WriteLine(ctr);
        }
    }
}
