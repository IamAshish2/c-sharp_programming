using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.strings
{
    //Write a program in C# Sharp to insert a substring before the first occurrence of a string.
    public class InsertBeforeString
    {
        public static void Insert(string str,string subStr,string insert)
        {
            //without library functions
            //string newString = "";
            //int index = str.IndexOf(subStr);
            //for(int i = 0; i < str.Length; i++)
            //{
            //    if (index - 1 == i)
            //        newString += insert;
            //    else newString += str[i];
            //}
            //Console.WriteLine(newString);

            int index = str.IndexOf(subStr);
            insert = " " + insert + " ";
            str = str.Insert(index, insert);
            Console.WriteLine(str);
        }
    }
}
