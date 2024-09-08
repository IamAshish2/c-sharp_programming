class Upper
{
    // rubbish code
    public static void UpperTrainglular(int[,] arr)
    {
        //for (int i = 0; i < arr.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arr.GetLength(1); j++)
        //    {
        //        if (i <= j)
        //        {
        //            Console.Write(arr[i, j] + " ");
        //        }
        //        else
        //        {
        //            Console.Write(0 + " ");
        //        }
        //    }
        //    Console.WriteLine();
        //}

        // Sum of right diagonal
        //int sum = 0;
        //for (int i = 0; i < arr.GetLength(0); i++)
        //{
        // if(i < arr.GetLength(1)) sum += arr[i,j]; best alternative

        ////    for (int j = 0; j < arr.GetLength(1); j++)
        ////    {
        ////        if (i == j)
        ////        {
        ////            Console.Write(i + " ");
        ////            Console.Write(j);
        ////            sum += arr[i, j];
        ////        }
        ////    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine(sum);

        // Sum of left diagonal
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            // best way 0(n) runtime
            int j = arr.GetLength(1) - 1 - i;
            sum += arr[i, j];

            ////for (int j = 0; j < arr.GetLength(1); j++)
            ////{
            ////    if (i == j && j - i != 1)
            ////    {
            ////        Console.Write(i + " ");
            ////        Console.Write(j);
            ////        sum += arr[i, j];
            ////    }
            ////}
            ////Console.WriteLine();
        }
        Console.WriteLine(sum);
    }
}