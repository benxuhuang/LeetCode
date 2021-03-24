using System;

namespace _0101._Symmetric_Tree__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(3);
            Console.WriteLine(IsSymmetric(root));
        }


        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return IsSymmetric(root.left, root.right);
        }

        public static bool IsSymmetric(TreeNode l, TreeNode r)
        {
            if (l == null && r == null) return true;
            if (l == null || r == null) return false;
            if (l.val != r.val) return false;

            return IsSymmetric(l.left, r.right) && IsSymmetric(l.right, r.left);
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
