using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.Stacks
{
    internal class DecimalToBinary
    {
        const int max = 20;
        static int[] binary = new int[max];
        static int top = -1;
        public static void Convert(int num)
        {            
                while (num != 0)
                {
                    int rem = num % 2;
                    //Console.WriteLine(rem); 
                    Push(rem);
                    num /= 2;
                }
            Print();
        }

        static void Push(int data)
        {
            if(top == max -1)
            {
                Console.WriteLine("Stack overflow");
                Environment.Exit(0);
            }
            top++;
            binary[top] = data;
        }
        
        static void Print()
        {
            Console.WriteLine("The number in binary is: ");
            for (int i = top; i >= 0; i--) Console.Write(binary[i] + " ");
            Console.WriteLine();
        }
    }
}
