using System;

namespace _0063.Unique_Paths_II__Medium_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 0, 0, 0 };
            arr[1] = new int[] { 0, 1, 0 };
            arr[2] = new int[] { 0, 0, 0 };

            Console.WriteLine(UniquePathsWithObstacles(arr));
            Console.ReadLine();
        }

        public static int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            if (obstacleGrid == null || obstacleGrid[0][0] == 1) return 0;

            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;

            //m = row, n = column
            int[,] res = new int[m, n];
            res[0, 0] = 1;

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    //判斷是否為障礙，如果是則不累計
                    if (obstacleGrid[i][j] != 1)
                    {
                        if (i - 1 >= 0)
                            res[i, j] += res[i - 1, j];
                        if (j - 1 >= 0)
                            res[i, j] += res[i, j - 1];
                    }
                }
            }

            return res[m - 1, n - 1];
        }
    }
}
