    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace c_sharp.Arrays
    {
        public class AddElementToSortedArr
        {
            // Method to add element in sorted arr
            public static void AddEle()
            {
                int[] arr = new int[10];
                int val = 3;
                int pos = 2;
                int n = arr.Length;

            for (int i=0;i<6;i++)
            {
                arr[i] = i+1;
            }

            Console.WriteLine("Intial vaues");            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            // determining the postion to insert the value
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (val < arr[i])
            //    {
            //        pos = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(pos);

            //shifting the values to the right
            for (int i=n-1;i>=pos;i--)
            {
                arr[i] = arr[i-1];
            }
            arr[pos] = val;

            Console.WriteLine("Final values");
            // printing the values
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        }
    }
