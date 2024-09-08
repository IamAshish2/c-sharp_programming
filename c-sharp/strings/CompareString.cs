using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.strings
{
    //Write a program in C# Sharp to compare two strings without using a string library functions.
    public class CompareString
    {
        public static void Compare(string a,string b)
        {
            bool isEqual = false;
            int aLen = a.Length;
            int bLen = b.Length;
            if (aLen == bLen) 
            {
                for (int i = 0; i < aLen; i++)
                {
                    if(a[i] == b[i]) isEqual = true;
                }
            }
            

            Console.WriteLine(isEqual ? "yes" : "false");
        }
    }
}
