using System;

namespace _0367._Valid_Perfect_Square__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isPerfectSquare(16));
        }

        static bool isPerfectSquare(int num)
        {
            if (num < 1) return false;
            if (num == 1) return true;

            int min = 0;
            int max = num;

            while (min <= max)
            {
                //var mid = (max + min) / 2;
                //直接平均可能會溢位，所以用此算法
                var mid = min + (max - min) / 2;

                if ((long)mid * mid == num)
                {
                    return true;
                }
                else if ((long)mid * mid < num)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return false;
        }
    }
}
