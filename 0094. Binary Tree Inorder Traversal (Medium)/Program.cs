using System;
using System.Collections.Generic;

namespace _0094._Binary_Tree_Inorder_Traversal__Medium_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(43);
            root.left = new TreeNode(33);
            root.right = new TreeNode(61);
            root.left.left = new TreeNode(20);
            root.left.right = new TreeNode(37);
            root.right.left = new TreeNode(54);
            root.right.right = new TreeNode(66);

            //InOrderTraversalByRecursion(root);
            InOrderTraversalByIterative(root);
        }

        /// <summary>
        /// Recursion version
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        static List<int> InOrderTraversalByRecursion(TreeNode root)
        {
            List<int> res = new List<int>();
            InOrder(root, res);
            return res;
        }

        static void InOrder(TreeNode root, List<int> res)
        {
            if (root == null) return;
            InOrder(root.left, res);
            res.Add(root.val);
            InOrder(root.right,res);
        }

        /// <summary>
        /// Iterative version
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        static IList<int> InOrderTraversalByIterative(TreeNode root)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode curr = root;
            while (curr != null || stack.Count != 0)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                res.Add(curr.val);
                curr = curr.right;
            }
            return res;
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
