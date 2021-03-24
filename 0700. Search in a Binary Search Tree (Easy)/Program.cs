using System;

namespace _0700._Search_in_a_Binary_Search_Tree__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(4);
            tree.left = new TreeNode(2);
            tree.left.left = new TreeNode(1);
            tree.left.right = new TreeNode(3);
            tree.right = new TreeNode(7);

            Console.WriteLine(SearchBST(tree,2));
        }

        public static TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null || root.val == val)
                return root;

            if (val <= root.val)
                return SearchBST(root.left, val);
            else
                return SearchBST(root.right, val);
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
