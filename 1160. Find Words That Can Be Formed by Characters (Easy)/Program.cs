using System;

namespace _1160._Find_Words_That_Can_Be_Formed_by_Characters__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            string chars = "atach";
            string[] words = new string[] { "cat", "bt", "hat", "tree" };
            Console.WriteLine(CountCharacters(words, chars));
        }

        public static int CountCharacters(string[] words, string chars)
        {
            int result = 0;

            //使用一個陣列來存chars字串中(a~z)的數量
            int[] charsArr = new int[26];

            //計算chars字串中每個字元出現(a~z)的數量
            foreach (var c in chars)
            {
                //因為ASCII的關係，其始基準點為a，
                //如果c為字元a: charsArr[a - 'a']= charsArr[0]
                //字元b: charsArr[b - 'a']= charsArr[1] ...
                ++charsArr[c - 'a'];
            }

            //比較words中的元素與chars字串中(a~z)的數量，並回傳累計的長度。
            foreach (var w in words)
            {
                result += Compare(w, charsArr);
            }

            return result;
        }

        public static int Compare(string word, int[] charsArr)
        {
            int[] wordCharArr = new int[26];

            foreach (var c in word)
            {
                ++wordCharArr[c - 'a'];

                if (wordCharArr[c - 'a'] > charsArr[c - 'a'])
                    return 0;
            }

            return word.Length;
        }

    }
}
