using System;
using System.Collections;
using System.Linq;

namespace _0190._Reverse_Bits__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(reverseBits(1001100));
        }

        public static int reverseBits(int n)
        {
            if (n == 0) return 0;

            int result = 0;

            for (int i = 0; i < 32; i++)
            {
                result <<= 1;

                //將n和1進行AND運算來確認最右邊的位元
                if ((n & 1) == 1) 
                    result++;

                n >>= 1;
            }

            return result;
        }


    }
}
