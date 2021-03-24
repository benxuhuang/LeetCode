using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = LongestCommonPrefix(new string[] { "flower", "slow", "flight" });
            Console.WriteLine(result);
        }

        public static string LongestCommonPrefix(string[] strs)
        {

            if (strs == null || strs.Length == 0)
                return "";

            string pre = strs[0];

            int i = 1;

            while(i < strs.Length)
            {
                while (strs[i].IndexOf(pre) != 0)
                    pre = pre.Substring(0, pre.Length - 1);
                i++;
            }

            return pre;

            //strs = strs.OrderBy(d => d.Length).ToArray();

            //var minLengthWord = strs[0].ToCharArray();

            //List<string> result = new List<string>();

            //for (int i = 1; i < strs.Length; i++)
            //{
            //    var charArr = strs[i].ToCharArray();

            //    if (result.Count != 0)
            //    {
            //        for (int j = 0; j < result.Count; j++)
            //        {
            //            if (result[j] == charArr[j].ToString())
            //            {
            //                if (!result.Contains(charArr[j].ToString()))
            //                {
            //                    result.Add(charArr[j].ToString());
            //                }
            //            } else
            //            {
            //                result.Remove(result[j]);
            //            }
            //        }
            //    } else
            //    {
            //        for (int j = 0; j < minLengthWord.Length; j++)
            //        {
            //            if (minLengthWord[j] == charArr[j])
            //            {
            //                if (!result.Contains(minLengthWord[j].ToString()))
            //                {
            //                    result.Add(minLengthWord[j].ToString());
            //                }
            //            }
            //        }
            //    }
            //}

            //return string.Join("", result.ToArray());
        }
    }
}
