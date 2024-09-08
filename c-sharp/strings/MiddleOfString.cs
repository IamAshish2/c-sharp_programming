using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.strings
{
    //Write a C# Sharp program to find the central character(s) in a given string.
    //    Return the middle character if the string length
    //    is odd and return two middle characters if the string length is even.
    public class MiddleOfString
    {
        public static void Middle(string str)
        {
            int len = str.Length;
            int mid = len / 2 ;

            if (len % 2 == 0) Console.WriteLine(str.Substring(mid-1,2));
            else Console.WriteLine(str[mid]);
        }
    }
}
