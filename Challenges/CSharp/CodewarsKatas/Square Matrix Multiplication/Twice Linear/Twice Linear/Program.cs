using System;
using System.Collections.Generic;

namespace Twice_Linear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DblLinear(10));
        }

        public static int DblLinear(int n)
        {
            int point1 = 0;
            int point2 = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                result[i] = Math.Min(2 * result[point1] + 1, 3 * result[point2] + 1);
                if (result[i] == 2 * result[point1] + 1) point1++;
                if (result[i] == 3 * result[point2] + 1) point2++;
            }
            return result[n];
        }
    }
}
