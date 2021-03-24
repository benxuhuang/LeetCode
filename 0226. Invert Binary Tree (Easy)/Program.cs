using System;

namespace _0226._Invert_Binary_Tree__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;

            //交換左右節點
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            //遞迴檢查各個節點是否需要交換
            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}

