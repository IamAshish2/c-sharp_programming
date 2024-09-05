using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp._2_D_Arrays
{
    //Write a program in C# Sharp to print or display the lower triangular of a given matrix.
    public class LowerTraingluarOfMatrix
    {
        public static void LowerMatrix(int[,] arr)
        {
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i <=j)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(0 +" ");
                    }
                }
                Console.WriteLine();    
            }
        }
    }
}
