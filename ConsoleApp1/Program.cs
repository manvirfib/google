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
            MaxHeap maxHeap = new MaxHeap();

            maxHeap.Insert(10);
            maxHeap.Insert(20);
            maxHeap.Insert(30);
            maxHeap.Insert(25);
            maxHeap.Insert(5);
            maxHeap.Insert(40);
            maxHeap.Insert(35);

            maxHeap.display();
        }
    }
}