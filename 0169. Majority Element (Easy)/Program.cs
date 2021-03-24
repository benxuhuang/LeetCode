using System;
using System.Collections.Generic;
using System.Linq;

namespace _0169._Majority_Element__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine(MajorityElement(nums));
        }

        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if (dic.ContainsKey(item) == true)
                    dic[item] += 1;
                else
                    dic.Add(item, 1);
            }

            return dic.OrderByDescending(x => x.Value).FirstOrDefault().Key;
        }
    }
}
