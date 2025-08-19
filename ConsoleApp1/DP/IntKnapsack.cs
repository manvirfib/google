namespace HelloWorld
{
    class Intknapsack
    {
        int[,] arr;
        public Intknapsack(int[,] arr)
        {
            this.arr = arr;
        }
        public int CalculateOptimalSolution(int n, int m)
        {
            if (n == 0 || m == 0)
                return 0;

            if (arr[n, 1] <= m)
            {
                int leftProfit = CalculateOptimalSolution(n - 1, m);
                int rightProfit = arr[n, 0] + CalculateOptimalSolution(n - 1, m - arr[n, 1]);

                return leftProfit > rightProfit ? leftProfit : rightProfit;
            }
            else
            {
                int leftProfit = CalculateOptimalSolution(n - 1, m);
                return leftProfit;
            }
        }
    }
}