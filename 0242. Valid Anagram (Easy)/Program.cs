using System;

namespace _0242._Valid_Anagram__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "rat", t = "car";
            Console.WriteLine(IsAnagram(s,t));
        }
        public static bool IsAnagram(string s, string t)
        {
            if (s == null || t == null || s.Length != t.Length) return false;

            int[] sCharArr = new int[26];

            foreach (var c in s)
            {
                ++sCharArr[c - 'a'];
            }

            foreach (var c in t)
            {
                if (sCharArr[c - 'a'] > 0)
                    --sCharArr[c - 'a'];
                else
                    return false;
            }

            return true;
        }
    }
}
