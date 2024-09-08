using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.strings
{
    //Write a C# Sharp program to find the maximum number of characters in a string.
    public class MaxChars
    {
        public static void MaxCount(string str)
        {
            int n = str.Length;
            int[] ch_freq = new int[255];

            // initialize 0 frequency for all characters
            for(int i = 0; i < 255; i++)
            {
                ch_freq[i] = 0;
            }

            // calculate frequency for the characters in str
            for(int i = 0;i < n;i++)
            {
                int ascii = (int) str[i]; // Get the ascii value for the specific character
                ch_freq[ascii]++; // increment that ascii character's freqency
            }

            // find the most repeated character
            int max = 0;
            for(int i = 0;i < 255;i++)
            {
                // exclude the space character
                if(i != 32)
                {
                    if (ch_freq[i] > ch_freq[max]) max = i;
                }
            }
            Console.WriteLine("The character with the most repetition in the given string is: " + (char)max + " with "+
            + (char)ch_freq[max] + " repititions.");
        }

    }
}
