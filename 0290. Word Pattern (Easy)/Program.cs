using System;
using System.Collections;

namespace _0290._Word_Pattern__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordPattern("abba", "dog cat cat dog"));
        }

        public static bool WordPattern(string pattern, string str)
        {
            Hashtable ht = new Hashtable();

            //判斷長度
            int pLen = pattern.Length;
            string[] strArr = str.Split(" ");

            if (pLen != strArr.Length)
            {
                return false;
            }

            //判斷內容
            char[] patternArr = pattern.ToCharArray();

            for (int i = 0; i < pLen; i++)
            {
                char c = patternArr[i];

                //判斷key有沒有此 pattern 字元
                if (!ht.ContainsKey(c))
                {
                    //沒有此key則判斷有沒有此value，如果沒有則放入key與value
                    if (!ht.ContainsValue(strArr[i]))
                    {
                        ht.Add(c, strArr[i]);
                    }
                    else
                    {
                        //如果有value則代表此value與其他的key已經對應則回傳false
                        return false;
                    }
                }
                else
                {
                    //有key則判斷此key的value是否與strArr所對應的value一致
                    if (ht[c].ToString() != strArr[i])
                    {
                        return false;
                    }
                }

            }

            return true;
        }

    }
}
