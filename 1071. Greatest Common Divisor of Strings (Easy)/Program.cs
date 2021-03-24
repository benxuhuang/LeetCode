using System;

namespace _1071._Greatest_Common_Divisor_of_Strings__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GcdOfStrings("LEET", "CODE"));
        }

        public static string GcdOfStrings(string str1, string str2)
        {
            //先判斷兩個字串的長度，較長的字串需放前面(str1)減去後面較短的字串(str2)
            int str1Len = str1.Length;
            int str2Len = str2.Length;

            //如果str2長度大於str1則交換位置
            if (str2Len > str1Len)
            {
                return GcdOfStrings(str2, str1);
            }

            //比較長字串是否與短字串相等
            if (str1.Equals(str2))
            {
                return str1;
            }

            //開始做減去遞迴
            if (str1.StartsWith(str2))
            {
                return GcdOfStrings(str1.Substring(str2Len), str2);
            }
            else
            {
                //一開始就不一樣代表沒有共同字串
                return "";
            }
        }
    }
}
