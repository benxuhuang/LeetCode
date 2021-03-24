using System;

namespace BinarySearchTreeImplementation
{
    class Program
    {
        /// <summary>
        /// http://csharpexamples.com/tag/tree-traversal/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(4);
            binarySearchTree.Add(2);
            binarySearchTree.Add(6);
            binarySearchTree.Add(1);
            binarySearchTree.Add(3);
            binarySearchTree.Add(5);
            binarySearchTree.Add(7);

            Node node = binarySearchTree.Find(7);

            int depth = binarySearchTree.GetTreeDepth();

            Console.WriteLine("PreOrder Traversal:");
            binarySearchTree.TraversePreOrder(binarySearchTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            binarySearchTree.TraverseInOrder(binarySearchTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            binarySearchTree.TraversePostOrder(binarySearchTree.Root);
            Console.WriteLine();

            binarySearchTree.Remove(2);

            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binarySearchTree.TraversePreOrder(binarySearchTree.Root);
            Console.WriteLine();
        }
    }
}
