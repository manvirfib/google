namespace HelloWorld
{
    class Intknapsack
    {
        int[,] arr;
        int[,] dp;
        public Intknapsack(int[,] arr, int n, int m)
        {
            this.arr = arr;
            dp = new int[n + 1, m + 1];
        }

        public int CalculateOptimalSolution(int n, int m)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (arr[i, 1] <= j)
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], arr[i, 0] + dp[i - 1, j - arr[i, 1]]);
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }

            return dp[n, m];
        }
    }
}