﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProgram
{
    public class BinarySearchTree<K> where K : IComparable
    {

        public BinarySearchTreeNode<K> Root;

        public void AddNode(K Key)
        {
            Root = AddRecursively(Root, Key);
        }
        public K GetRoot { get { return Root.Key; } }
        public K GetRootLeft { get { return Root.Left.Key; } }
        public K GetRootRight { get { return Root.Right.Key; } }

        private BinarySearchTreeNode<K> AddRecursively(BinarySearchTreeNode<K> Current, K Key)
        {

            if (Current == null)
                return new BinarySearchTreeNode<K>(Key);


            int CompareResult = Key.CompareTo(Current.Key);

            if (CompareResult == 0)
                return Current;

            if (CompareResult < 0)
                Current.Left = AddRecursively(Current.Left, Key);

            else
                Current.Right = AddRecursively(Current.Right, Key);
            return Current;

        }
        public int GetSize()
        {
            return this.getSizeRecursively(Root);
        }

        private int getSizeRecursively(BinarySearchTreeNode<K> Current)
        {

            return Current == null ? 0 : 1 + this.getSizeRecursively(Current.Left)
                                           + this.getSizeRecursively(Current.Right);
        }

    }
}
