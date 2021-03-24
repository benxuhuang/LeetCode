using System;
using System.Collections.Generic;

namespace _0202._Happy_Number__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isHappy(19));
        }

        public static bool isHappy(int n)
        {
            HashSet<int> set = new HashSet<int>();

            int next;

            while (!set.Contains(n))
            {
                if (n == 1) return true;

                set.Add(n); next = 0;

                while (n != 0)
                {
                    //做餘數，取出個位數字。
                    int remain = n % 10;
                    //做除數，取出十位數字。
                    n /= 10;
                    next += remain * remain;
                }
                n = next;
            }
            return false;
        }
    }
}
