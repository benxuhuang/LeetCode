using System;

namespace _0404._Sum_of_Left_Leaves__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(3);
            tree.left = new TreeNode(9);
            tree.right = new TreeNode(20);
            tree.right.left = new TreeNode(15);
            tree.right.right = new TreeNode(7);

            Console.WriteLine(SumOfLeftLeaves(tree));
        }

        public static int SumOfLeftLeaves(TreeNode root)
        {
            if (root == null) return 0;
            return SumOfLeftLeaves(root.left, "L") + SumOfLeftLeaves(root.right, "R");
        }

        public static int SumOfLeftLeaves(TreeNode node, string side)
        {
            if (node == null) return 0;
            if (side == "L" && node.left == null && node.right == null) return node.val;
            return SumOfLeftLeaves(node.left, "L") + SumOfLeftLeaves(node.right, "R");
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
