using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp._2_D_Arrays
{
    //Write a C# Sharp program to find the transpose of a given matrix.
    public class Transpose
    {
        public static void GetTranspose(int[,] arr)
        {
            // int[,] arr = { { 1, 2,4,5,6,7 }, { 9, 8 ,11,22,33,44} };
            //Transpose.GetTranspose(arr);


            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);    
            int[,] transpose = new int[cols,rows];

            Console.WriteLine("Array before Transpose: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }


            // transpose the matrix i.e. change the rows and columns
            for (int i=0;i < rows;i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    transpose[j,i] = arr[i, j];
                }
            }

            // print arr
            Console.WriteLine("Array after Transpose: ");
            for (int i=0;i<transpose.GetLength(0); i++)
            {
                for(int j = 0; j < transpose.GetLength(1); j++)
                {
                    Console.Write(transpose[i,j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
