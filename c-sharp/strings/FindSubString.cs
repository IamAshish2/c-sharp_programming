using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.strings
{
    //Write a program in C# Sharp to search for the position of a substring within a string.
    public class FindSubString
    {
        public static void FindString(string str,string subString)
        {
            // without library function
            //int strLen = str.Length;
            //int subLen = subString.Length;
            //for (int i=0;i<strLen-subLen;i++)
            //{
            //    if (str.Substring(i, subLen) == subString) 
            //        Console.WriteLine("Substring {0} found at index {1} to {2}.",subString,i,i+subLen-1);
            //}

            int index = str.IndexOf(subString);
            if(index < 0)
            {
                Console.WriteLine("NOt found");
                return;
            }
            Console.WriteLine(index);

        }
    }
}
