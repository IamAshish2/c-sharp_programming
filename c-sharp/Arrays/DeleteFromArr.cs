using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.Arrays
{
    //Write a C# Sharp program to delete an element at the desired position from an array.
    public class DeleteFromArr
    {
        //DeleteFromArr.DeleteEle(new[] { 1, 34, 98, 4, 5 }, 5, 2);
        public static void DeleteEle(int[] arr,int n, int pos)
        {
            for (int i=pos;i<n-1;i++)
            {
                arr[i] = arr[i + 1];
            }
            PrintArr(arr);
        }

        private static void PrintArr(int[] arr)
        {
            foreach (int i in arr) Console.WriteLine(i);
        }
    }
}
