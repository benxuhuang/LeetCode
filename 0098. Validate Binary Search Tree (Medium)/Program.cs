using System;

namespace _0098._Validate_Binary_Search_Tree__Medium_
{
    class Program
    {
        static TreeNode last;

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(43);
            root.left = new TreeNode(33);
            root.right = new TreeNode(61);
            root.left.left = new TreeNode(20);
            root.left.right = new TreeNode(37);
            root.right.left = new TreeNode(54);
            root.right.right = new TreeNode(66);

            Console.WriteLine(isValidBST(root));
        }

        static bool isValidBST(TreeNode root)
        {
            if (root == null) return true;
            if (!isValidBST(root.left)) return false;
            if (last != null && root.val <= last.val) return false;
            last = root;
            return isValidBST(root.right);
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
