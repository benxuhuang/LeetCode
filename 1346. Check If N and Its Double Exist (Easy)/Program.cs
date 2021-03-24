using System;
using System.Collections.Generic;

namespace _1346._Check_If_N_and_Its_Double_Exist__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 2, 5, 3 };
            Console.WriteLine(CheckIfExist(arr));
        }

        public static bool CheckIfExist(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                //判斷 dic 的 value 是否有item數值*2
                if (dic.ContainsValue(arr[i] * 2))
                {
                    return true;
                }
                else
                {
                    //判斷是否有item數值/2
                    if (arr[i] % 2 == 0 && dic.ContainsValue(arr[i] / 2))
                    {
                        return true;
                    }
                    else
                    {
                        //都沒有則將item數值add到dic中
                        dic.Add(i, arr[i]);
                    }
                }
            }

            return false;
        }

    }
}
