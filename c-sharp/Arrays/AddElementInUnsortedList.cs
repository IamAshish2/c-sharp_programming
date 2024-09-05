using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.Arrays
{
    public class AddElementInUnsortedList
    {
        // AddElementInUnsortedList.Add(new[] { 1,34,98,4,5},5,3,56);
        public static void Add(int[] arr, int n,int pos,int val)
        {
            for (int i=n-1; i>=pos; i--)
            {
                arr[i] = arr[i-1];
            }
            arr[pos] = val;
            printArray(arr);
        }

        public static void printArray(int[] arr)
        {
            foreach (int ele in arr)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
