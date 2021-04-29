using System;
using System.Collections.Generic;

namespace _0144.Binary_Tree_Preorder_Traversal__Medium_
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(5);
            root.right.left = new TreeNode(7);
            root.right.right = new TreeNode(8);
            root.left = new TreeNode(3);
            root.left.left = new TreeNode(2);
            root.left.right = new TreeNode(3);
            Console.WriteLine(PreOrderTraversalByIterative(root));

            List<int> result = new List<int>();
            PreOrderTraversalByRecursive(root, result);
            Console.WriteLine(result.ToString());
        }


        //preorder: root -> left -> right
        public static List<int> PreOrderTraversalByIterative(TreeNode root)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();

            if (root != null)
            {
                stack.Push(root);
                while (stack.Count != 0)
                {
                    TreeNode n = stack.Pop();
                    if (n.right != null)
                        stack.Push(n.right);
                    if (n.left != null)
                        stack.Push(n.left);
                    result.Add(n.val);
                }
            }
            return result;
        }

        public static void PreOrderTraversalByRecursive(TreeNode root, List<int> result)
        {
            if (root == null) return;
            result.Add(root.val);
            PreOrderTraversalByRecursive(root.left, result);
            PreOrderTraversalByRecursive(root.right, result);
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
