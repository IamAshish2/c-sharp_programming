using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.Arrays
{
    public class SecondSmallestEle
    {
        public static void FindSecondSmallestEle(int[] arr)
        {
            int min = arr[0];
            // ensure maxvalue for proper comparison
            int ele = int.MaxValue;
            int n = arr.Length;

            // find the min value first
            for (int i=0;i<n;i++)
            {
                if (arr[i] < min) min = arr[i]; 
            }
            Console.WriteLine(min);

            // find the second smallest value 
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > min && arr[i] < ele) ele = arr[i];
            }
            Console.WriteLine(ele);
        }
    }
}
