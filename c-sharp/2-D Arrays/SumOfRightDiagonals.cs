using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp._2_D_Arrays
{
    public class SumOfRightDiagonals
    {
        //Write a C# Sharp program to find the sum of the right diagonals of a matrix.

        // int[,] arr = { { 1, 2 }, { 9, 8} };
        //SumOfRightDiagonals.FindSum(arr);
        public static void FindSum(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            int diagonalSum = 0;
            int antiDiagonalSum = 0;

            // calculate sum of right-diagonal
            for (int i=0;i<rows;i++)
            {
                 if (i < cols) diagonalSum += arr[i, i];
            }

            // Calculate the anti diagonal sum
            //for (int i=0;i<rows;i++)
            //{
            //    int j = cols - i - 1;
            //    if(j >=0 && j < cols) antiDiagonalSum += arr[i, j];
            //}

            Console.WriteLine("The diagonalSum of the arr is {0}",diagonalSum);
            Console.WriteLine("The antiDiagonalSum of the arr is {0}", antiDiagonalSum);
        }
    }
}
