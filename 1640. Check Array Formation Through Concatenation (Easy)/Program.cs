using System;
using System.Collections.Generic;

namespace _1640._Check_Array_Formation_Through_Concatenation__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new int[] { 91, 4, 64, 78 };
            //int[][] pieces = { { 78 }, { 4, 64 }, { 91 } };
            int[][] pieces = new int[3][]; 
            pieces[0] = new int[] {78 }; 
            pieces[1] = new int[] {4,64 }; 
            pieces[2] = new int[] {91}; 
            canFormArray(arr, pieces);

            int[] array = new int[] { };
            array = new int[] { 1};
        }

        static bool canFormArray(int[] arr, int[][] pieces)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < pieces.Length; ++i)
            {
                dic.Add(pieces[i][0], i);
            }

            int index = 0;

            while (index < arr.Length)
            {
                //如果字典裡沒有 arr 陣列的 key 則代表 pieces 裡沒有 arr 的數值
                if (!dic.ContainsKey(arr[index])) return false;

                //取出字典中 key 為 arr 數值的對應陣列數值
                int value = (int)dic[arr[index]];

                //取出字典中對應 arr 數值的陣列，並依序比較陣列內的數字是否跟 arr 一致
                foreach (int n in pieces[value])
                {
                    if (n != arr[index++]) return false;
                }
            }

            return true;
        }
    }
}
