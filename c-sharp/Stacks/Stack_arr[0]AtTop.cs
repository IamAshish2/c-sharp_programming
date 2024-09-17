using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.Stacks
{
    // WAP to implement a stack in an array stack_arr[] using stack_arr[0] as the top element.
    // the 0th index is always the top element
    internal class Stack_arr_0_AtTop
    {
        const int max = 6;
        static int[] numbers = new int[max];
        static int firstEle = -1; // keeping track of the first inserted element i.e. 0 index

        public static void Enter()
        {
            Push(30);
            Push(90);
            Push(69);
            Print();
            Console.WriteLine("pop");
            Pop();
            Print();

        }

        // push an element to the stack
        static void Push(int data)
        {

            if (isFull())
            {
                Console.WriteLine("Stack overflow");
                Environment.Exit(0);
            }

            firstEle++;
            for (int i = firstEle; i > 0; i--)
            {
                // rightward shifting of the elements
                numbers[i] = numbers[i - 1];
            }
            numbers[0] = data;
        }

        // pop an element from the stack
        static int Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack underflow");
                Environment.Exit(1);
            }

            int removed = numbers[0];
            // leftward shifting of elements
            for (int i = 0; i < firstEle; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            firstEle--;
            return removed;

        }

        // check if the stack is empty
        static bool isEmpty()
        {
            return firstEle == -1;
        }

        // check if the stack is full
        static bool isFull()
        {
            return firstEle == max - 1;
        }

        static int Peek()
        {
            if (!isEmpty())
            {
                Console.WriteLine("Stack underflow");
                Environment.Exit(1);
            }
            return numbers[0];
        }
        static void Print()
        {
            for (int i = 0; i <= firstEle; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
