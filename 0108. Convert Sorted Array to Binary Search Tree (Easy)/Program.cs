using System;

namespace _0108._Convert_Sorted_Array_to_Binary_Search_Tree__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -10, -3, 0, 5, 9 };
            SortedArrayToBST(nums);
        }

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0 || nums == null) return null;
            return getTreeNode(nums, 0, nums.Length - 1);
        }

        public static TreeNode getTreeNode(int[] nums, int start, int end)
        {
            //如果start大於end代表交叉
            if (start > end) return null;

            int mid = (start + end) / 2;

            TreeNode root = new TreeNode(nums[mid]);
            root.left = getTreeNode(nums, start, mid - 1);
            root.right = getTreeNode(nums, mid + 1, end);
            return root;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

    }
}
