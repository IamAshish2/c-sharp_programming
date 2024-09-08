//4.Write a program in C# Sharp to print individual characters of the string in reverse order.

using System.ComponentModel;

namespace c_sharp.strings
{
    //Write a C# Sharp program to find the length of a string without using a library function.
    public class Reverse
    {
        public static void ReverseStr(string str)
        {
            string rev = "";
            foreach (char c in str)
            {
                rev = c + rev;
            }
            Console.WriteLine(rev);
        }
    }
}
