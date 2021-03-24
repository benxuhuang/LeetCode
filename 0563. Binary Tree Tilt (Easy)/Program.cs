using System;

namespace _0563._Binary_Tree_Tilt__Easy_
{
    public class Program
    {
        public int result = 0;

        public void Main(string[] args)
        {
            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(3);

            Console.WriteLine(FindTilt(tree));
        }

        public int FindTilt(TreeNode root)
        {
            Dfs(root);
            return result;
        }

        public int Dfs(TreeNode n)
        {
            if (n == null) return 0;
            int l = Dfs(n.left);
            int r = Dfs(n.right);
            result += Math.Abs(l - r);
            return l + r + n.val;
        }

    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode() { }
        public TreeNode(int val) { this.val = val; }
        public TreeNode(int val, TreeNode left, TreeNode right)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}
