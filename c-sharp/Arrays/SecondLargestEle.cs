using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.Arrays
{
    //Write a C# Sharp program to find the second largest element in an array.
    public class SecondLargestEle
    {
        public static void FindSecondLargestEle(int[] arr)
        {
            // SecondLargestEle.FindSecondLargestEle(new int[] {1,2,88,56,98,22,34});
            int ele = arr[0];
            int max = int.MinValue;
            int n = arr.Length;

            // Find the max value first
            for (int i=0;i<n-1;i++) 
            {
                if (arr[i] > max) max = arr[i];
            }

            //Console.WriteLine(max);

            // Find the second largest element
            for(int i = 0; i < n; i++)
            {
                if (arr[i] < max && arr[i] > ele) ele= arr[i];
            }
            Console.WriteLine(ele);
        }
    }
}
