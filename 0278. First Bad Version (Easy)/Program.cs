using System;

namespace _0278._First_Bad_Version__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstBadVersion(8));
        }

        public static int FirstBadVersion(int n)
        {
            int lo = 1, hi = n;

            while (hi > lo)
            {
                int mid = lo + (hi - lo) / 2; //避免溢位

                if (IsBadVersion(mid))
                {
                    hi = mid;
                }
                else
                {
                    lo = mid + 1;
                }
            }

            return lo;
        }
    }
}
