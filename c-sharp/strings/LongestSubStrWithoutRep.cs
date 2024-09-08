using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.strings
{
    // check this
    //Write a C# Sharp program to find the length of the longest substring without repeating characters in a given string.
    public class LongestSubStrWithoutRep
    {
        //String str1;
        //str1 = "aaaaaabbbbccc";
        //Console.WriteLine("Original String: " + str1);

        //// Calculate and display the length of the longest substring without repeating characters
        //Console.WriteLine("Length of the longest substring without repeating characters of the said string:");
        //Console.WriteLine(LongestSubStrWithoutRep.without_repeated_chars_longest_substring(str1));
        public static int without_repeated_chars_longest_substring(string str1)
        {
            var map_str = new Dictionary<char,int>();
            int max_len = 0;
            int last_repeat_pos = -1;
            // Loop through the string
            for (int i = 0; i < str1.Length; i++)
            {
                // Check if the character exists in the dictionary and update its last position
                if (map_str.ContainsKey(str1[i]) && last_repeat_pos < map_str[str1[i]])
                    last_repeat_pos = map_str[str1[i]];

                // Check for the maximum length of the non-repeating substring
                if (max_len < i - last_repeat_pos)
                {
                    Console.WriteLine(max_len);
                    max_len = i - last_repeat_pos;
                }

                // Store current character and its position in the dictionary
                map_str[str1[i]] = i;
            }
            return max_len;
        }
    }
}
