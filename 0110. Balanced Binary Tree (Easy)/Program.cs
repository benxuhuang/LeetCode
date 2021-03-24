using System;

namespace _0110._Balanced_Binary_Tree__Easy_
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
            Console.WriteLine(IsBalanced(root));
        }

        public static bool balance = true;
        public static bool IsBalanced(TreeNode root)
        {
            Maxdp(root);
            return balance;
        }

        public static int Maxdp(TreeNode root)
        {
            if (root == null || !balance) return 0;
            int l = Maxdp(root.left);
            int r = Maxdp(root.right);
            if (Math.Abs(l - r) > 1)
            {
                balance = false;
                return 0;
            }
            return Math.Max(l, r) + 1;
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
