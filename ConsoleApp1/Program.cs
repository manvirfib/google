using System.IO.Compression;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            BST bTree = new BST();
            bTree.Insert(10);
            bTree.Insert(5);
            bTree.Insert(20);
            bTree.Insert(8);
            bTree.Insert(30);

            bTree.Inorder();
            Console.WriteLine(bTree.Search(99)?.value);
        }
    }
}