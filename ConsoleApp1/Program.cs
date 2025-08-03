namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Create();
            tree.PreOrder(tree.root);

            tree.IPreOrder(tree.root);
            Console.WriteLine();
            tree.InOrder(tree.root);
            Console.WriteLine();
            tree.IInOrder(tree.root);
            Console.WriteLine();
            tree.PostOrder(tree.root);
            tree.LevelOrder(tree.root);

            Console.WriteLine();
            Console.WriteLine(tree.HeightOfTree(tree.root));
            Console.WriteLine(tree.CountNodes(tree.root));
            Console.WriteLine(tree.CountLeafNodes(tree.root));
        }
    }
}