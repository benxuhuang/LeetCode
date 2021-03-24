using System;
using System.Collections.Generic;
using System.Linq;

namespace _0438._Find_All_Anagrams_in_a_String__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            FindAnagrams("cbaebabacd", "abc");
            Console.WriteLine("Hello World!");
        }

        public static IList<int> FindAnagrams(string s, string p)
        {
            List<int> result = new List<int>();

            if (s == null || p == null) return result;
            if (s.Length < p.Length) return result;

            int[] hp = new int[26];
            int[] hs = new int[26];

            int N = s.Length, L = p.Length;

            //將p字串中的各個字元累積總數存到hp陣列中
            foreach (var c in p)
            {
                ++hp[c - 'a'];
            }

            //透過滑動窗口方法
            for (int i = 0; i < N; i++)
            {
                //窗口內的第一個字元往後一格(當i<L時窗口不需要向後移動)
                if(i >= L)
                    --hs[s[i - L] - 'a'];

                //窗口內的最後一個字元往後面往後一格
                ++hs[s[i] - 'a'];

                if(hs.SequenceEqual(hp) == true)
                {
                    result.Add(i - L + 1);
                }
            }

            return result;
        }
    }
}
