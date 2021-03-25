using System;
using System.Collections.Generic;

namespace _0015._3Sum__Medium_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -1, 0, 1, 2, -1, -4 };
            Console.WriteLine(ThreeSum(arr));
        }

        static IList<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();

            //sort by asc
            Array.Sort(nums);

            //first < nums.Length - 2 是因為 first 最多僅需移動到陣列的倒數第3個位置
            for (int first = 0; first < nums.Length - 2; first++)
            {
                //如果 first 與前一個一樣則可以跳過這次不檢查，因為已檢查過一樣的組合。
                if (first > 0 && nums[first] == nums[first - 1])
                    continue;

                int second = first + 1;
                int third = nums.Length - 1;

                while (second < third)
                {
                    //如果 second 與前一個一樣則可以跳過這次不檢查，因為已檢查過一樣的組合。
                    if (nums[second] == nums[second - 1] && second > first + 1)
                    {
                        second++;
                        continue;
                    }

                    int sum = nums[second] + nums[third] + nums[first];
                    if (sum == 0)
                    {
                        var temp = new List<int>() { nums[first], nums[second], nums[third] };
                        result.Add(temp);
                        second++;
                        third--;
                    }
                    else if (sum > 0)
                    {
                        third--;
                    }
                    else
                    {
                        second++;
                    }
                }
            }

            return result;
        }
    }
}
