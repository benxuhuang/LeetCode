using System;

namespace _0191._Number_of_1_Bits__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HammingWeight(11100));
        }

        public static int HammingWeight(uint n)
        {
            if (n == 0) return 0;

            int result = 0;

            for (int i = 0; i < 32; i++)
            {
                //將n和1進行AND運算來確認最右邊的位元
                if ((n & 1) == 1)
                    result++;

                n >>= 1;
            }

            return result;
        }
    }
}
