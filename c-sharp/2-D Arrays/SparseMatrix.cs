using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp._2_D_Arrays
{
    public class SparseMatrix
    {
        public static void CheckSparseMatrix(int[,] arr)
        {
            int zeroCounter = 0; // initialize a zero counter to keep track of all zero's that present in the array
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int i=0;i<rows;i++) // loop through rows
            {
                for (int j=0; j<cols;j++)
                {
                    if (arr[i,j] == 0) zeroCounter++;
                }
            }

            if (zeroCounter > (rows * cols) / 2) Console.WriteLine("The given matrix is a sparse matrix.");
            else Console.WriteLine("Not a sparse matrix.");
        }
    }
}
