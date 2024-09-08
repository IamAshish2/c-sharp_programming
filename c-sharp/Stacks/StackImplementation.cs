using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp.Stacks
{
    //Write a C# program to implement a stack with push and pop operations.
    //Find the top element of the stack and check if the stack is empty or not.
    public class StackImplementation
    {
        
        public static void Implement()
        {
            Stack<string> ele = new Stack<string>();
            ele.Push("Ashish");
            ele.Push("Karki");
            ele.Push("items");

            foreach (var item in ele) Console.Write(item + " ");
            Console.WriteLine();

            var itemRemoved = ele.Pop();
            Console.WriteLine("The item removed from the stack " + itemRemoved + " ");

            if (ele.Peek() == " ") Console.WriteLine("No items in the stack");
            else Console.WriteLine(ele.Peek());

        }
    }
}
