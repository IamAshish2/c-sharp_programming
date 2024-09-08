using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.strings
{
    //. Write a C# Sharp program to read a sentence and replace lowercase characters with uppercase and vice-versa.
    public class ChangeCase
    {
        public static void Change(string s)
        {
            string small = "abcdefghijklmnopqrstuvwxyz";
            string cap = small.ToUpper();

            foreach (char c in s)
            {
                if (c == ' ')
                {
                    Console.Write(" ");
                }
                else
                {
                    if (cap.Contains(c)) Console.Write(c.ToString().ToLower());
                    else Console.Write(c.ToString().ToUpper());
                }
                
            }
        }
    }
}
