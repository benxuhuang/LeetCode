using System;

namespace _0680._Valid_Palindrome_II__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidPalindrome("abcceba"));
        }

        public static bool ValidPalindrome(string s)
        {
            char[] arr = s.ToCharArray();
            for (int i = 0, j = arr.Length-1; i < j; ++i, --j)
            {
                if (arr[i] != arr[j])
                {
                    //略過1個字的兩邊其中只要一邊字元一樣即可
                    return isPalindrome(arr, i + 1, j) || isPalindrome(arr, i, j - 1);
                }
            }
            return true;
        }

        /// <summary>
        /// 略過1個字檢查剩下的字元，如果全部都一樣才回傳True。
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        private static bool isPalindrome(char[] arr, int l, int r)
        {
            for (; l < r; ++l, --r)
            {
                if (arr[l] != arr[r])
                    return false;
            }
            return true;
        }
    }
}
