namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Element[] items = {
            //     new Element { profit = 12, weight = 2 },
            //     new Element { profit = 17, weight = 5 },
            //     new Element { profit = 9, weight = 7 },
            //     new Element { profit = 7, weight = 3 },
            //     new Element { profit = 5, weight = 1 },
            //     new Element { profit = 21, weight = 4 },
            //     new Element { profit = 8, weight = 1 }
            // };

            // KnapSack ks = new KnapSack(items, 15);
            // Console.WriteLine("Maximum Profit: " + Math.Round(ks.CalculateProfit(), 2));

            int[,] items = {
                { 1, 2, 28 },
                { 1, 6, 10 },
                { 2, 3, 16 },
                { 2, 7, 14 },
                { 3, 4, 12 },
                { 4, 5, 22 },
                { 4, 7, 18 },
                { 5, 6, 25 },
                { 5, 7, 24 }
            };

            int nodes = 7;

            Kruskal kr = new Kruskal(items, nodes);

            Console.WriteLine(kr.FindMST());

            // int[,] graph = new int[,] {
            //     // 0.  1.  2.  3.  4.  5.  6
            //     { -1, -1, -1, -1, -1, -1, -1 }, //0
            //     { -1,  0,  1,  5, -1, -1, -1 }, //1
            //     { -1,  1,  0,  3, 10,  8, -1 }, //2
            //     { -1,  5,  3,  0, -1,  2, -1 }, //3
            //     { -1, -1, 10, -1,  0,  3,  2 }, //4
            //     { -1, -1,  8,  2,  3,  0,  7 }, //5
            //     { -1, -1, -2, -1,  2,  7,  0 }  //6
            // };

            // Dijkstra dijkstra = new Dijkstra(graph);
            // dijkstra.GetMinimumDistanceFromSource(1);

            int[,] arr = new int[,] {
                { 0, 0 },
                { 6, 1 },
                { 5, 2 },
                { 3, 1 },
                { 8, 2 }
            };
            Intknapsack knap = new Intknapsack(arr);
            Console.WriteLine(knap.CalculateOptimalSolution(4, 5));
        }
    }
}