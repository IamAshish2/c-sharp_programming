

namespace c_sharp.Stacks
{
    internal class Pilot
    {
        private const int max = 5;
        private static string[] names = new string[max];
        private static int top = -1;

        public static void Enter()
        {
            Push("Ashish");
            Push("Mausam");
            Push("Rabin");
            Push("muksham");
            Push("Luffy");
            Push("Duffer");// stack overflow as the array is full at this point
            Console.WriteLine("After push operation");
            PrintStack(names);
            Pop();
            Pop();
            Console.WriteLine("After pop operation");
            PrintStack(names);
        }

        // push operation
        public static void Push(string data)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow! Can't Push  {0} in the Stack.",data);
                //Environment.Exit(0);
                return;
            }

            top++;
            names[top] = data;
        }

        // pop operation
        public static void Pop()
        {
            if(top == -1)
            {
                Console.WriteLine("No items in the Stack");
                return;
            }
            names[top] = "";
            top--;
        }

        // Print the stack elements
        public static void PrintStack(string[] arr)
        {
            foreach(string s in arr) Console.WriteLine(s);
        }
    }
}
