using System;

namespace _0977._Squares_of_a_Sorted_Array__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { -4, -1, 0, 3, 10 };
            sortedSquares(A);
        }

        public static int[] sortedSquares(int[] A)
        {
            int[] result = new int[A.Length];

            //先將負數轉為正整數
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    A[i] = -A[i];
                }
            }

            //使用兩個point開始比較兩端數值，
            //數值比較大者取平方後放至result陣列右方，
            //並從result陣列右邊依序放至左邊。
            for (int i = A.Length - 1, l = 0, r = A.Length - 1; i >= 0; i--)
            {
                if (A[l] > A[r])
                {
                    //左邊數值大於右邊數值
                    result[i] = A[l] * A[l];
                    l++;
                } else
                {
                    //右邊大於左邊
                    result[i] = A[r] * A[r];
                    r--;
                }
            }

            return result;
        }
    }
}
