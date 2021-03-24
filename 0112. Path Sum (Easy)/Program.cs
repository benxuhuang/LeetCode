using System;

namespace _0112._Path_Sum__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(5);
            tree.left = new TreeNode(4);
            tree.left.left = new TreeNode(11);
            tree.left.left.left = new TreeNode(7);
            tree.left.left.right = new TreeNode(2);
            tree.right = new TreeNode(8);
            tree.right.left = new TreeNode(13);
            tree.right.right = new TreeNode(4);
            tree.right.right.right = new TreeNode(1);

            Console.WriteLine(HasPathSum(tree, 22));
        }

        public static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;
            if (root.left == null && root.right == null)
            {
                if (root.val == sum)
                    return true;
                else
                    return false;
            }

            var remains = sum - root.val;
            return HasPathSum(root.left, remains) || HasPathSum(root.right, remains);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
