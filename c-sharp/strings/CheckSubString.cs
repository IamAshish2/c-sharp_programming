using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.strings
{
    //Write a C# Sharp program to check whether a given substring is present in the given string.
    public class CheckSubString
    {
        public static void isPresent(string s,string sub)
        {
            bool isPresent = false;
            if(s.Contains(sub)) isPresent = true;
            Console.WriteLine(isPresent ? "The substring is present" : "The substring is not present");
        }
    }
}
