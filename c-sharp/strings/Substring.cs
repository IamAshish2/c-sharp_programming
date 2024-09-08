using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.strings
{
    //Write a program in C# Sharp to extract a substring from a given string without using the library function.
    public class Substring
    {
        public static void getSubString(string str,int s,int l) // parameters with the start index and the length of the substring
        {
            for(int i = s; i < s + l; i++)
            {
                if (str[i] == ' ') Console.Write(" ");
                else Console.Write(str[i]);
            }
        }
    }
}
