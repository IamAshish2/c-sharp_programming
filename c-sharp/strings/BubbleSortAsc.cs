using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.strings
{
    //Write a C# Sharp program to sort a string array in ascending order.
    public class BubbleSortAsc
    {
        public static void sortString(string str)
        {
            char[] arr1;
            char ch;
            arr1 = str.ToCharArray(0,str.Length);

            // sort the string using bubble sort
            for (int i=0;i<str.Length;i++)
            {
                for(int j =0; j < str.Length -1 ; j++)
                {
                    if (arr1[j] > arr1[i])
                    {
                      ch = arr1[j];
                     arr1[j] = arr1 [i];
                    arr1[i] = ch;
                    }
                }
            }

            // Display the string
            foreach (char c in arr1) Console.Write(c + " ");
        }
    }
}
