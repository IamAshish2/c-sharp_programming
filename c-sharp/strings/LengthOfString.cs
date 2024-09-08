
using System.ComponentModel;

namespace c_sharp.strings
{
    //Write a C# Sharp program to find the length of a string without using a library function.
    public class LengthOfString
    {
        public static void FindLength(string str)
        {
            int ctr = 0;
            foreach (char c in str)
            {
                ctr++;
            }
            Console.WriteLine(ctr);

            
        }
    }
}
