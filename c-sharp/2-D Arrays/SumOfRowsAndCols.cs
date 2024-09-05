using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp._2_D_Arrays
{
    // Write a C# Sharp program to find the sum of rows and columns in a matrix.
    public class SumOfRowsAndCols
    {
        public static void CalculateSum(int[,] arr)
        {

            //int[,] arr = { { 1, 2 }, { 7, 8 } };
            //SumOfRowsAndCols.CalculateSum(arr);

            int n = arr.GetLength(1);

            int[] rowSum = new int[n];
            int[] colSum = new int[n];

            // Calculating the sum of rows
            for (int i=0;i<n;i++)
            {
                 rowSum[i] = 0;
                for (int j=0;j<n;j++)
                {
                    rowSum[i] += arr[i,j];
                }
                
            }

            // Displaying the sum of each row
            foreach (int row in rowSum) Console.Write(row + " ");

            // Calculating the sum of Colums
            for (int i = 0; i < n; i++)
            {
                colSum[i] = 0;
                for (int j = 0; j <n;j++)
                {
                    colSum[i] += arr[j,i];
                }

            }

            // Displaying the sum of each col
            foreach (int col in colSum) Console.Write(col + " ");
        }
    }
}
