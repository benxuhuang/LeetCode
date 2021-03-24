using System;
using System.Collections.Generic;

namespace _0217._Contains_Duplicate__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 1 };
            Console.WriteLine(ContainsDuplicate(nums));
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 0) return false;

            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (dic.ContainsKey(item) == true)
                {
                    return true;
                }
                else
                {
                    dic.Add(item, item);
                }
            }

            return false;
        }
    }
}
