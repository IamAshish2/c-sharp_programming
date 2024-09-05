using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp._2_D_Arrays
{
    //. Write a C# Sharp program to print or display an upper triangular matrix.
    public class UpperTraingularMatrix
    {
        //int[,] arr = { { 1, 2, 3, }, { 4, 5, 6, }, { 7, 8, 9 } };
        //UpperTraingularMatrix.UpperMatrix(arr);
        public static void UpperMatrix(int[,] matrix)
        {
            for (int i=0;i<matrix.GetLength(0);i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        Console.Write(0 + " ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
