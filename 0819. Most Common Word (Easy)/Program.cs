using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _0819._Most_Common_Word__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "a, a, a, a, b,b,b,c, c";
            string[] banned = new string[] { "a" };
            Console.WriteLine(MostCommonWord(paragraph, banned));
        }

        public static string MostCommonWord(string paragraph, string[] banned)
        {
            //轉小寫
            paragraph = paragraph.ToLower();

            //去除符號
            string trimPara = Regex.Replace(paragraph, @"[^\w\s]", " ");

            //轉成陣列
            string[] paragraphArr = trimPara.Split(' ');

            //比較單字是否有再banned陣列中，如果沒有則加入字典

            Dictionary<string, int> dic = new Dictionary<string, int>();

            foreach (var item in paragraphArr)
            {
                if (banned.Contains(item) == false && item != "")
                {
                    //加入字典
                    //判斷字典是否已有此字串資料
                    if (dic.ContainsKey(item) == true)
                    {
                        //有資料則累計
                        dic[item] = dic[item] + 1;
                    }
                    else
                    {
                        //沒有則新增一筆累計1的資料
                        dic.Add(item, 1);
                    }
                }
            }

            return dic.FirstOrDefault(x => x.Value == dic.Max(d => d.Value)).Key;
        }
    }
}

