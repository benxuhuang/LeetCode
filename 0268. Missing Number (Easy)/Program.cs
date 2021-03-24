using System;

namespace _0268._Missing_Number__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            Console.WriteLine(missingNumber(nums));
        }

        public static int missingNumber(int[] nums)
        {
            int n = nums.Length;
            int total = n * (n + 1) / 2;
            int numsTotal = 0;
            foreach (var item in nums)
            {
                numsTotal += item;
            }
            return total - numsTotal;
        }
    }
}
