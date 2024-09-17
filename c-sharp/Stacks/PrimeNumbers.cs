using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.Stacks
{
    internal class PrimeNumbers
    {
        // WAP to print all the prime factors of a number in desceneding order using stacks.
        const int max = 20;
        static int[] nums = new int[max];
        static int top = -1;
        public static void FindPrime()
        {

            int num = 450;
            for (int i=2;i<=num;i++)
            {
                while (num % i == 0)
                {
                    Push(i);
                    num /= i;
                }
            }
            Print();
        }

        static void Push(int data)
        {
            if (isFull())
            {
                Console.WriteLine("Stack overflow");
                Environment.Exit(0);    
            }
            top++;
            nums[top] = data;
        }

        static int Pop(int data)
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack underFlow");
                Environment.Exit(0);
            }

            int removed = nums[top];
            top--;
            return removed;
        }

        static bool isEmpty()
        {
            return top == -1;
        }

        static bool isFull()
        {
            return top == max - 1;
        }

        static void Print()
        {
            for (int i=top;i>=0;i--)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
