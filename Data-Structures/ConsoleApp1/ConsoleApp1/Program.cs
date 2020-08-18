using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GRID 1");
            char[,] grid = new char[,] { { 'N', 'E', 'S' }, { 'S', 'S', 'E' }, { 'S', 'W', 'N' } };
            var g1a1 = EscapeGrid(grid, 0, 0);
            var g1a2 = EscapeGrid(grid, 1, 1);
            var g1a3 = EscapeGrid(grid, 2, 2);
            var g1a4 = EscapeGrid(grid, 2, 4);
            Console.WriteLine(string.Join(" => ", g1a1));
            Console.WriteLine(string.Join(" => ", g1a2));
            Console.WriteLine(string.Join(" => ", g1a3));
            Console.WriteLine(string.Join(" => ", g1a4));


            Console.WriteLine("GRID 2");
            char[,] grid2 = new char[,] { { 'N', 'S', 'W' }, { 'E', 'S', 'E' }, { 'N', 'W', 'W' } };
            var g2a1 = EscapeGrid(grid, 0, 0);
            var g2a2 = EscapeGrid(grid, 1, 1);
            var g2a3 = EscapeGrid(grid, 3, 2);
            Console.WriteLine(string.Join(" => ", g2a1));
            Console.WriteLine(string.Join(" => ", g2a2));
            Console.WriteLine(string.Join(" => ", g2a3));


            Console.WriteLine("GRID 3");
            char[,] grid3 = new char[,] { { 'N', 'S', 'W', 'N' }, { 'E', 'S', 'E', 'W' }, { 'N', 'W', 'W', 'S' } };
            var g3a1 = EscapeGrid(grid, 1, 4);
            var g3a2 = EscapeGrid(grid, 3, 0);
            var g3a3 = EscapeGrid(grid, 3, 2);
            Console.WriteLine(string.Join(" => ", g3a1));
            Console.WriteLine(string.Join(" => ", g3a2));
            Console.WriteLine(string.Join(" => ", g3a3));
        }

        public static List<string> EscapeGrid(char[,] arr, int j, int i)
        {
            int x = arr.GetLength(0);
            int y = arr.GetLength(1);
            List<string> steps = new List<string>();

            if (i >= x || i < 0 || j >= y || j < 0)
            {
                steps.Add("Started out of grid");
                return steps;
            }
            int count = 0;
            bool escaped = false;
            while (!escaped && count < x*y+1)
            {
                steps.Add(arr[i, j].ToString());
                switch (arr[i, j])
                {
                    case 'N':
                        i--;
                        break;
                    case 'S':
                        i++;
                        break;
                    case 'E':
                        j++;
                        break;
                    case 'W':
                        j--;
                        break;
                }
                count++;
                if (i >= x || i < 0 || j >= y || j < 0)
                {
                    escaped = true;
                    steps.Add($"Escaped successfully in {count} steps");
                }
            }
            if (!escaped)
            {
                steps.Add("Couldn't escape!");
            }
            return steps;
        }
    }
}
