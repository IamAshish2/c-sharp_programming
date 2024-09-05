using c_sharp._2_D_Arrays;
using c_sharp.Arrays;
using System.Net.Http.Headers;

class Program
{
    public static void Main(string[] args)
    {
        int[,] arr = { { 2,6,8 }, { 10,12,14 },{ 16,18,20} };
        Determinant.CalculateDeterminant(arr);
    }
}