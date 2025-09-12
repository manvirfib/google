using SegmentTree;
namespace HelloWorld
{
    class Abc
    {
        public void stablish()
        {
            Console.WriteLine();
        }
    }
    class Bcn : Abc
    {
        public void Gen()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Abc abc = new Bcn();

            // int[,] arr = {
            //     {0, 1, 1, 1, 0, 1, 1, 1}, //0
            //     {0, 1, 1, 1, 0, 1, 1, 1},//1
            //     {0, 0, 1, 0, 1, 0, 0, 1},//2
            //     {0, 0, 1, 0, 1, 1, 0, 1},//3
            //     {0, 1, 1, 1, 0, 1, 0, 0},//4
            //     {0, 1, 0, 0, 0, 1, 0, 0},//5
            //     {0, 1, 1, 1, 0, 1, 1, 1},//6
            //     {0, 0, 0, 1, 1, 1, 0, 1},//7

            // };
            // RatInMaze rmz = new RatInMaze(arr);
            // rmz.Run(1, 1);

            // Console.WriteLine();
            // int[,] A = {
            //     { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },//0
            //     { 0, 0, 0, 1, 9, 0, 8, 0, 7, 2 },//1
            //     { 0, 6, 4, 9, 2, 0, 0, 0, 0, 0 },//2
            //     { 0, 0, 0, 7, 6, 3, 0, 0, 4, 0 },//3
            //     { 0, 0, 5, 3, 0, 0, 0, 0, 0, 0 },//4
            //     { 0, 0, 0, 0, 0, 0, 4, 3, 9, 0 },//5
            //     { 0, 0, 0, 0, 8, 2, 0, 1, 0, 0 },//6
            //     { 0, 0, 0, 0, 0, 0, 7, 4, 1, 5 },//7
            //     { 0, 1, 8, 5, 0, 9, 2, 0, 6, 0 },//8
            //     { 0, 0, 7, 0, 0, 0, 6, 9, 2, 0 } //9
            // };

            // SudokuSolver sd = new SudokuSolver(A);

            // int[] segArr = { 8, 2, 5, 1, 4, 5, 3, 9, 6, 10 };
            // SegmentTree2 segmentTree = new SegmentTree2(segArr);
            // Console.WriteLine(segmentTree.MaxBetween(3, 4));

            // FenwickTree inv = new FenwickTree(10);

            // inv.AddSupply(2, 50);
            // Console.WriteLine(inv.Query(9));
            // inv.AddSupply(3, 50);
            // Console.WriteLine(inv.Query(9));

            // var inv = new InventorySystem(5);

            // inv.AddSupply(2, 50);
            // Console.WriteLine(inv.GetInventory(2)); // 50
            // Console.WriteLine(inv.GetInventory(3)); // 50

            // inv.AddDemand(1, 20);
            // Console.WriteLine(inv.GetInventory(2)); // 30 (50 - 20)
            // Console.WriteLine(inv.GetInventory(4));

            //Heap implementation
            MaxHeapify maxHeapify = new MaxHeapify(5);
            maxHeapify.Enqueue(1);
            maxHeapify.Enqueue(5);
            maxHeapify.Enqueue(3);
            maxHeapify.Enqueue(15);
            maxHeapify.Enqueue(16);

            Console.WriteLine(maxHeapify.Dequeue());
            Console.WriteLine(maxHeapify.Dequeue());
            Console.WriteLine(maxHeapify.Dequeue());
            Console.WriteLine(maxHeapify.Dequeue());
            Console.WriteLine(maxHeapify.Dequeue());
            Console.WriteLine(maxHeapify.Dequeue());
        }
    }

    class MaxHeapify
    {
        int size;
        int[] heap;
        int cur = 1;
        public MaxHeapify(int size)
        {
            this.size = size + 1;
            heap = new int[this.size];
        }
        public void Enqueue(int value)
        {
            if (cur < size)
            {
                int parent = cur / 2;
                int i = cur;
                while (parent > 0)
                {
                    if (value > heap[parent])
                    {
                        heap[i] = heap[parent];
                        i = parent;
                        parent = parent / 2;
                    }
                    else
                    {
                        break;
                    }
                }
                heap[i] = value;
                cur++;
            }
            else
            {
                Console.WriteLine("Heap is full");
            }
        }

        public int Dequeue()
        {
            if (cur <= 1)
            {
                Console.WriteLine("Heap is empty");
                return -1;
            }
            cur--;
            int temp = heap[cur];
            heap[cur] = heap[1];
            heap[1] = temp;

            int i = 1;

            while ((2 * i + 1) < (cur))
            {
                if (heap[2 * i] > heap[2 * i + 1])
                {
                    if (heap[i] > heap[2 * i])
                    {
                        break;
                    }
                    int val = heap[i];
                    heap[i] = heap[2 * i];
                    heap[2 * i] = val;
                    i = 2 * i;
                }
                else
                {
                    if (heap[i] > heap[2 * i + 1])
                    {
                        break;
                    }
                    heap[i] = heap[2 * i + 1];
                    i = 2 * i + 1;
                }
            }

            return heap[cur];
        }
    }
}