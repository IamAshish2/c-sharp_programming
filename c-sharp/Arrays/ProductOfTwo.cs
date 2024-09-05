using System;

namespace c_sharp.Arrays
{
    public class ProductOfTwo
    {
        public static void ProductOfTwoNums(int[] arr, int product)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] * arr[j] == product)
                    {
                        Console.WriteLine($"The two numbers whose product is equal to {product} are {arr[i]} and {arr[j]}");
                        return;
                    }
                }
            }
            Console.WriteLine("No such pair exists.");
        }
    }
}
