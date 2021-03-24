using System;

namespace _0111._Minimum_Depth_of_Binary_Tree__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            Console.WriteLine(MinDepth(root));
        }

        public static int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            int l = MinDepth(root.left);
            int r = MinDepth(root.right);
            if (l == 0 || r == 0)
                return l + r + 1;
            else
                return Math.Min(l, r) + 1;
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
