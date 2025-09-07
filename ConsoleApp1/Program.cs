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

            int[] segArr = { 8, 2, 5, 1, 4, 5, 3, 9, 6, 10 };
            SegmentTree segmentTree = new SegmentTree(segArr);
            Console.WriteLine(segmentTree.MaxBetween(3, 4));

            FenwickTree inv = new FenwickTree(10);

            inv.AddSupply(2, 50);
            Console.WriteLine(inv.Query(9));
            inv.AddSupply(3, 50);
            Console.WriteLine(inv.Query(9));


        }
    }
}