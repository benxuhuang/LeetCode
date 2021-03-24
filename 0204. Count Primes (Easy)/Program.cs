using System;

namespace _0204._Count_Primes__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountPrimes(3));
        }

        public static int CountPrimes(int n)
        {
            if (n < 3) return 0;

            int sum = 0;

            //檢查2~n-1個數是否為質數
            for (int i = 2; i < n; i++)
            {
                bool isPrimes = true;

                //針對目標數的開根號 +1
                int sqrt = Convert.ToInt32(Math.Sqrt(i)) + 1;

                //檢查2~目標數的開根號的數是否能整除目標數
                for (int j = 2; j <= sqrt; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        //可以整除所以非質數
                        isPrimes = false;

                        //因為已檢查到此數(i)非質數所以可以跳出j迴圈後面檢查，往下一個i檢查。
                        break;
                    }
                }

                if (isPrimes) sum++;
            }

            return sum;
        }
    }
}
