using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp._2_D_Arrays
{
    //Write a C# Sharp program to calculate the determinant of a 3 x 3 matrix.
    public class Determinant
    {
        public static void CalculateDeterminant(int[,] arr)
        {
            // Display the entered matrix
            Console.Write("The matrix is :\n");
            for (int i = 0; i < 3; i++) // Loop through rows
            {
                for (int j = 0; j < 3; j++) // Loop through columns
                    Console.Write("{0}  ", arr[i, j]); // Print each element of the matrix
                Console.Write("\n"); // Move to the next row
            }


            int determinant = 0;
            for (int i=0;i<3;i++) // get determinant for 3 X 3 matrix
            {
                determinant += arr[0, i] * arr[1, (i + 1) % 3] * arr[2, (i + 2) % 3] - arr[0, (i + 2) % 3] * arr[1, (i + 1) % 3] * arr[2, i];
                // Applying the formula for the determinant of a 3x3 matrix
                //int determinant = arr[0, 0] * (arr[1, 1] * arr[2, 2] - arr[1, 2] * arr[2, 1])
                //                - arr[0, 1] * (arr[1, 0] * arr[2, 2] - arr[1, 2] * arr[2, 0])
                //                + arr[0, 2] * (arr[1, 0] * arr[2, 1] - arr[1, 1] * arr[2, 0]);
            }


            Console.WriteLine(determinant);
        }
    }
}
