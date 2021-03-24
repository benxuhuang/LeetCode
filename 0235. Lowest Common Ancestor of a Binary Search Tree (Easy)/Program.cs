using System;

namespace _0235._Lowest_Common_Ancestor_of_a_Binary_Search_Tree__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(6);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);
            root.left.right.left = new TreeNode(3);
            root.left.right.right = new TreeNode(5);
            root.right = new TreeNode(8);
            root.right.left = new TreeNode(7);
            root.right.right = new TreeNode(9);

            TreeNode p = new TreeNode(2);
            TreeNode q = new TreeNode(4);

            Console.WriteLine(LowestCommonAncestor(root,q,p).val);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            while(true)
            {
                var value = root.val;

                if (p.val <= value && value <= q.val || p.val >= value && value >= q.val)
                {
                    return root;
                }
                else if (p.val > value && q.val > value)
                {
                    root = root.right;
                }
                else
                {
                    root = root.left;
                }
            }
        }
    }
}
