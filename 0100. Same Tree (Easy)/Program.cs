using System;

namespace _0100._Same_Tree__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode p = new TreeNode(1);
            p.left = new TreeNode(2);
            p.right = new TreeNode(1);

            TreeNode q = new TreeNode(1);
            q.left = new TreeNode(4);
            q.right = new TreeNode(1);

            Console.WriteLine(IsSameTree(p, q));
        }

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;

            return (p.val == q.val) && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
