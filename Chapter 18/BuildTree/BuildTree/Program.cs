using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace BuildTree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoWork();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DoWork()
        {
            Tree<char> charTree = new Tree<char>('M');
            InsertIntoTree<char>(charTree, 'X', 'A', 'M', 'Z', 'N');
            charTree.WalkTree();
        }

        static void InsertIntoTree<TItem>(Tree<TItem> tree, params TItem[] data)
            where TItem : IComparable<TItem>
        {
            if(data.Length == 0)
            {
                throw new ArgumentException("Must provide at least one data value");
            }

            foreach(TItem datum in data)
            {
                tree.Insert(datum);
            }
        }
    }
}
