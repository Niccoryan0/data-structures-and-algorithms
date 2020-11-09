using System;

namespace Square_Matrix_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[,] SquareMatrixMult(int[,] a, int[,] b)
        {
            int len = a.GetLength(0);
            var result = new int[len,len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < len; k++)
                        result[i, j] += (a[i, k] * b[k, j]);
                }
            }
            return result;
        }
    }
}
