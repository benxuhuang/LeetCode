using System;

namespace _0062._Unique_Paths__Medium_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniquePaths(7, 3));
            Console.ReadLine();
        }

        public static int UniquePaths(int m, int n)
        {
            //n=row, m = column
            int[,] grid = new int[n, m];

            for (int i = 0; i < m; i++)
                grid[0, i] = 1;

            for (int i = 0; i < n; i++)
                grid[i, 0] = 1;

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    grid[j, i] = grid[j, i - 1] + grid[j - 1, i];
                }
            }
            return grid[n - 1, m - 1];
        }
    }
}
