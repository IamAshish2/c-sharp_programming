using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.Arrays
{
    //Write a C# Sharp program to merge two arrays of the same size sorted in ascending order.
    public class MergeTwoArrays
    {
        public static void MergeArraysInAscending()
        {
            int m, n, o;
            int i;

            Console.WriteLine("Enter the length of First Array");
            m = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[m];

            Console.Write("Input {0} elements in the array :\n", m);
            for (int t = 0; t < arr1.Length; t++) 
            {
                Console.Write($"Enter the {t + 1} value:");
                arr1[t] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the length of Second Array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[n];

            Console.Write("Input {0} elements in the array :\n", n);
            for (int t = 0; t < arr2.Length; t++)
            {
                Console.Write($"Enter the {t + 1} value:");
                arr2[t] = Convert.ToInt32(Console.ReadLine());
            }

            // combine the length of arr1 and arr2 for arr3
            o = m + n;
            int[] arr3 = new int[o];

            // insert the first array values
            
            for( i=0; i < m; i++)
            {
                arr3[i] = arr1[i];
            }

            // insert values from the second array
            for (int j = 0; j < n; j++)
            {
                arr3[i] = arr2[j];
                i++;
            }

            // sort the merged array using bubble sort
            for (int j=0;j<o;j++)
            {
                for (int k=0;k<o-1;k++)
                {
                    if (arr3[j] < arr3[k])
                    {
                        int temp = arr3[j];
                        arr3[j] = arr3[k];
                        arr3[k] = temp;
                    }
                }
            }

            for (int k =0;k<o;k++)
            {
                Console.WriteLine(arr3[k]);
            }
        }
    }
}
