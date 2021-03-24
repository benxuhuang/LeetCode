using System;

namespace _0383._Ransom_Note__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanConstruct("aa","aab"));
        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            //先判斷magazine字元如果少於ransomNote則直接代表無法組成
            if (magazine.Length < ransomNote.Length)
                return false;

            //建立累計陣列
            int[] countArr = new int[26];

            //累計magazine字元
            foreach (var c in magazine.ToCharArray())
            {
                ++countArr[c - 'a'];
            }

            //扣除累計magazine字元，判斷是否字元充足。
            foreach (var c in ransomNote.ToCharArray())
            {
                if (--countArr[c - 'a'] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
