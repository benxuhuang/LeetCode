using System;
using System.Collections.Generic;

namespace _0257._Binary_Tree_Paths__Easy_
{
    class Program
    {
        public static List<string> result = null;

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(5);
            BinaryTreePaths(root);
        }

        public static List<string> BinaryTreePaths(TreeNode root)
        {
            result = new List<string>();

            if (root == null)
                return result;
            
            FindPath(root, "");

            return result;
        }

        public static void FindPath(TreeNode node, string prevPath)
        {
            if (node.left == null && node.right == null)
            {
                result.Add(prevPath + node.val);
            } 
            else
            {
                if (node.left != null)
                {
                    FindPath(node.left, prevPath + node.val + "->");
                }

                if (node.right != null)
                {
                    FindPath(node.right, prevPath + node.val + "->");
                }
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
}
