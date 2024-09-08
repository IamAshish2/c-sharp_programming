namespace c_sharp.Stacks
{
    internal class Pilot
    {
        private const int max = 5;
        private static string[] names = new string[max];
        private static int top = -1;

        public static void Enter()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Print the top Element.");
                Console.WriteLine("4. Print all Elements");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please Select an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter name to push:");
                        string name = Console.ReadLine();
                        Push(name);
                        break;
                    case 2:
                        string data = Pop();
                        Console.WriteLine("Element to be deleted {0}",data);
                        break;
                    case 3:
                        if (!isEmpty())
                            Console.WriteLine(names[top]);
                        else
                            Console.WriteLine("Stack is empty.");
                        break;
                    case 4:
                        Print();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Choose a correct Option!");
                        break;
                }
            }
        }

        // push operation
        public static void Push(string data)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow! Can't Push \"{0}\" in the Stack.", data);
                return;
            }
            top++;
            names[top] = data;
        }

        // pop operation
        public static string Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack UnderFlow");
                return null;
            }
            string data = names[top];
            top--;
            return data;
        }

        // Check if the stack is full
        public static bool IsFull()
        {
            return top == max - 1;
        }

        // Check if the stack is empty
        public static bool isEmpty()
        {
            return top == -1;
        }

        // Print the stack elements
        public static void Print()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            for (int i = top; i >= 0; i--)
            {
                Console.Write(names[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
