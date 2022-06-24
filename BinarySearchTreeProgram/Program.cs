using System;
namespace BinarySearchTreeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Binary Search Tree Program \n=========================================");
            BinarySearchTree<int> BinaryTree = new BinarySearchTree<int>();

            BinaryTree.AddNode(56);
            BinaryTree.AddNode(30);
            BinaryTree.AddNode(70);
            
        }
    }
}