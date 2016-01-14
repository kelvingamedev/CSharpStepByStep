using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree<TItem> where TItem : IComparable<TItem>
    {
        public TItem NoteData { get; set; }
        public Tree<TItem> LeftTree { get; set; }
        public Tree<TItem> RightTree { get; set; }

        public Tree(TItem nodeValue)
        {
            this.NoteData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
        }

        // Inserts a new item in a binary tree
        public void Insert(TItem newTItem)
        {
            TItem currentNodeValue = this.NoteData;
            if(currentNodeValue.CompareTo(newTItem) > 0)
            {
                if(LeftTree == null)
                {
                    this.LeftTree = new Tree<TItem>(newTItem);
                    this.LeftTree.LeftTree = null;
                    this.LeftTree.RightTree = null;
                }
                else
                {
                    this.LeftTree.Insert(newTItem);
                }
            }
            else
            {
                if(RightTree == null)
                {
                    this.RightTree = new Tree<TItem>(newTItem);
                    this.RightTree.LeftTree = null;
                    this.RightTree.RightTree = null;
                }
                else
                {
                    this.RightTree.Insert(newTItem);
                }
            }
        }

        // Walks trough the binary tree printing out the values
        public void WalkTree()
        {
            if(this.LeftTree != null)
            {
                this.LeftTree.WalkTree();
            }

            Console.WriteLine(this.NoteData.ToString());

            if(this.RightTree != null)
            {
                this.RightTree.WalkTree();
            }
        }

       
    }
}
