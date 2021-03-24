using System;

namespace _0205._Isomorphic_Strings__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isIsomorphic("paper", "title"));
        }

        public static bool isIsomorphic(String s, String t)
        {
            //如果兩個字串長度不同則回傳false
            if (s.Length != t.Length)
                return false;

            //建立對應陣列
            char[] smap = new char[128];
            char[] tmap = new char[128];

            //迴圈檢查字元
            char[] sCharArr = s.ToCharArray();
            char[] tCharArr = t.ToCharArray();

            for (int i = 0; i < sCharArr.Length; i++)
            {
                char sChar = sCharArr[i];
                char tChar = tCharArr[i];

                //如果對應陣列中沒有對應資料則會回傳0
                if (smap[sChar] == 0 && tmap[tChar] == 0)
                {
                    //設定對應字元，直接透過字元代碼當作索引設定位置
                    smap[sChar] = tChar;
                    tmap[tChar] = sChar;
                }
                else
                {
                    //有對應資料則檢查對應資料是否與之前所設定的字元一致
                    if (smap[sChar] != tChar || tmap[tChar] != sChar)
                    {
                        return false;
                    }
                }

            }

            return true;
        }
    }
}
