using System;

namespace _0687._Longest_Univalue_Path__Easy_
{
    class Program
    {
        private static int mx = 0;

        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(5);
            tree.left = new TreeNode(4);
            tree.left.left = new TreeNode(1);
            tree.left.right = new TreeNode(2);
            tree.right = new TreeNode(5);
            tree.right.right = new TreeNode(5);

            Console.WriteLine(LongestUnivaluePath(tree));
        }

        private static int max = 0;
        public static int LongestUnivaluePath(TreeNode root)
        {
            max = 0;
            GetMax(root);
            return max;
        }

        /// <summary>
        /// 由下往上做節點檢查
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private static int GetMax(TreeNode t)
        {
            if (t == null) return 0;
            
            int left = GetMax(t.left);
            int right = GetMax(t.right);
            
            int li = 0, ri = 0;
            
            if (t.left != null && t.left.val == t.val)
                li = left + 1;
            
            if (t.right != null && t.right.val == t.val)
                ri = right + 1;
            
            max = Math.Max(li + ri, max);
            
            return Math.Max(li, ri);
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
