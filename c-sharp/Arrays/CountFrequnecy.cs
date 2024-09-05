using System;

namespace c_sharp.Arrays
{
    public class CountFrequency
    {
        public static void Count()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 1, 2, 8, 5, 4 };
            int[] freq = new int[arr.Length];

            // Initialize frequency array with -1
            for (int i = 0; i < arr.Length; i++)
            {
                freq[i] = -1;
            }

            // Count frequency of each element
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1; // Start counting from 1 for the current element
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;     // Increment counter when duplicate is found
                        freq[j] = 0; // Mark duplicate elements as 0 in the frequency array
                    }
                }

                // If the element is not marked as duplicate, set its frequency
                if (freq[i] != 0)
                {
                    freq[i] = count;
                }
            }

            // Print the frequency of each element
            Console.WriteLine("The frequency of each element in the array is:");
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] != 0)
                {
                    Console.WriteLine($"{arr[i]} occurs {freq[i]} times");
                }
            }
        }
    }
}
