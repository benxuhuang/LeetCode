using System;

namespace _1332._Remove_Palindromic_Subsequences__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int removePalindromeSub(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string sReverse = new string(charArray);

            if (s == sReverse)
                return 1;
            else
                return 2;
        }
    }
}
