using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp._2_D_Arrays
{
    // Write a program to calculate the multiplication of a 2-d array
    public class Multiplication
    {
        //Multiplication.MultiplyArr();
        public static void MultiplyArr()
        {
            int[,] arr = { { 1, 2, 3, 4, 5, 6 }, { 7, 8, 9, 10, 11, 12 } };
            int[] arr2 = new int[6];
            //Console.WriteLine(arr.GetLength(0));
            int n = arr.GetLength(1);

            int f = 0;
            int j = 1;
            for (int i = 0; i < n;i++)
            {
                
                 arr2[i] = arr[f,i] * arr[j,i];
            }

            // printing the values
            foreach(int i in arr2) Console.WriteLine(i);
        }
    }
}
