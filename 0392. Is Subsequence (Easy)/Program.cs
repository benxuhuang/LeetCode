using System;

namespace _0392._Is_Subsequence__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSubsequence("abc", "ahbgdc"));
        }

        public static bool IsSubsequence(string s, string t)
        {
            //判斷字串長度
            if (t.Length < s.Length)
            {
                return false;
            }

            //迴圈檢查s是否為t的子序列
            int pre = 0;
            for (int i = 0; i < s.Length; i++, pre++)
            {
                //取出字元
                char sChar = s[i];
                //找字元位置出現在t字串的位置
                pre = t.IndexOf(sChar,pre);
                //如果回傳-1則代表沒找到此字元
                if (pre == -1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
