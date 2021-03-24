using System;

namespace _0088._Merge_Sorted_Array__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = new int[] { 2, 5, 6 };
            var reuslt = Merge(nums1, 3, nums2, 3);
        }

        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {

            //將nums2的元素放置nums1陣列中
            int index = 0;
            for (int i = m; i < m + n; i++)
            {
                nums1[i] = nums2[index];
                index++;
            }

            //使用bubble sort排序
            //從陣列的最前面開始，比較陣列中兩兩相鄰的元素，然後根據大小將它們調換順序，大的移到後面。
            for (int j = 0; j < nums1.Length - 1; j++)
            {
                for (int k = j + 1; k < nums1.Length; k++)
                {
                    if (nums1[j] > nums1[k])
                    {
                        int temp = nums1[k];
                        nums1[k] = nums1[j];
                        nums1[j] = temp;
                    }
                }
            }

            return nums1;
        }
    }
}
