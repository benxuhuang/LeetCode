using System;
using System.Collections.Generic;

namespace _0089._Gray_Code__Medium_
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = grayCode(4);
        }

        static List<int> grayCode(int n)
        {
            List<int> res = new List<int>();

            res.Add(0);

            if (n > 0)
            {
                int adder = 1;

                for (int i = 1; i <= n; i++)
                {
                    int len = res.Count;

                    for (int j = len - 1; j >= 0; j--)
                    {
                        res.Add(res[j] + adder);
                    }

                    adder *= 2;
                }
            }
            return res;
        }
    }
}
