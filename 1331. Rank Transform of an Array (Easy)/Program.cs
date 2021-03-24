using System;
using System.Collections.Generic;

namespace _1331._Rank_Transform_of_an_Array__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 40, 10, 20, 30 };

            Console.WriteLine(ArrayRankTransform(arr));
        }

        public static int[] ArrayRankTransform(int[] arr)
        {
            //arr 陣列複製到一個新的陣列 sortArr
            int[] sortArr = new int[arr.Length];
            Array.Copy(arr, sortArr, arr.Length);

            //sortArr 做小到大排序
            Array.Sort(sortArr);

            Dictionary<int, int> dic = new Dictionary<int, int>();

            //迴圈遍歷 sortArr 並每次遍歷時判斷數字是否已存在 Dictionary 中
            for (int i = 0; i < sortArr.Length; i++)
            {
                //如果沒有則將數字(key)加入 Dictionary 並將累計的rank 數字加入 value
                if (dic.ContainsKey(sortArr[i]) == false)
                {
                    dic.Add(sortArr[i], dic.Count + 1);
                }
            }

            //使用迴圈將原本的 arr 陣列內的數字替換成 Dictionary 中的 rank value
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = dic[arr[i]];
            }

            return arr;
        }
    }
}
