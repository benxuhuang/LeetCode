using System;
using System.Collections.Generic;

namespace Add_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101";
            string b = "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011";
            string result = AddBinary(a, b);
            Console.WriteLine(result);
        }

        public static string AddBinary(string a, string b)
        {
            char[] aCharArr = a.ToCharArray();
            char[] bCharArr = b.ToCharArray();

            //陣列反向後使用迴圈從前面両兩相加，迴圈使用陣列比較大的那個

            char[] maxCharArr, minCharArr;

            if (aCharArr.Length >= bCharArr.Length)
            {
                maxCharArr = aCharArr;
                minCharArr = bCharArr;
            }
            else
            {
                maxCharArr = bCharArr;
                minCharArr = aCharArr;
            }

            Array.Reverse(maxCharArr);
            Array.Reverse(minCharArr);

            int carry = 0, sum = 0;
            List<string> result = new List<string>();

            for (int i = 0; i <= maxCharArr.Length - 1; i++)
            {
                if (i < minCharArr.Length)
                    sum = Convert.ToInt32(maxCharArr[i] - '0') + Convert.ToInt32(minCharArr[i] - '0') + carry;
                else
                    sum = Convert.ToInt32(maxCharArr[i] - '0') + carry;

                if (sum == 0)
                {
                    carry = 0;
                    result.Add("0");
                }
                else if (sum == 1)
                {
                    carry = 0;
                    result.Add("1");
                }
                else if (sum == 2)
                {
                    carry = 1;
                    result.Add("0");
                }
                else if (sum == 3)
                {
                    carry = 1;
                    result.Add("1");
                }
            }

            if (carry != 0)
                result.Add("1");

            result.Reverse();

            return string.Join("", result);
        }

        //public static string AddBinary(string a, string b)
        //{
        //    long aNum = Convert.ToInt64(a, 2);
        //    long bNum = Convert.ToInt64(b, 2);
        //    long sum = aNum + bNum;
        //    string binary = Convert.ToString(sum, 2);
        //    return binary;
        //}
    }
}
