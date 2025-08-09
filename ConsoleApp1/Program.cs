namespace HelloWorld
{
    class Cacl
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public int subtract(int x, int y)
        {
            return x - y;
        }
    }
    class Program
    {
        public delegate int TestDelegate(int x, int y);
        static void Main(string[] args)
        {
            AVL bTree = new AVL();
            // // bTree.Insert(10);
            // // bTree.Insert(5);
            // // bTree.Insert(20);
            // // bTree.Insert(8);
            // // bTree.Insert(30);

            bTree.RInsert(bTree.root, 30);
            bTree.RInsert(bTree.root, 20);
            bTree.RInsert(bTree.root, 10);
            Console.WriteLine(bTree.GetHeight(bTree.root));
        }
    }
}