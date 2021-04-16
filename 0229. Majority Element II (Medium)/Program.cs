using System;
using System.Collections.Generic;
using System.Linq;

namespace _0229.Majority_Element_II__Medium_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 2, 2, 1, 1, 1, 1, 2, 2, 1, 1 };
            Console.WriteLine(MajorityElement(nums));
        }

        public static IList<int> MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], 1);
                else
                    dic[nums[i]] = dic[nums[i]] + 1;
            }

            int times = nums.Length / 3;

            return dic.Where(x => x.Value > times).Select(x => x.Key).ToList();
        }
    }
}
