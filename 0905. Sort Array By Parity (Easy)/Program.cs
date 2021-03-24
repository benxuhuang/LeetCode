using System;

namespace _0905._Sort_Array_By_Parity__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 3, 1, 2, 4 };
            Console.WriteLine(SortArrayByParity(A));
        }

        public static int[] SortArrayByParity(int[] A)
        {
            int i = 0, j = A.Length - 1;

            while(i<j)
            {
                if (A[i] % 2 == 0)
                {
                    ++i;
                    continue;
                }

                if (A[j] % 2 == 1)
                {
                    --j;
                    continue;
                }

                int temp = A[i];
                A[i] = A[j];
                A[j] = temp;
            }

            return A;
        }


    }
}
