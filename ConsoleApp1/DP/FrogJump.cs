class FrogJump
{
    public int minCost(int[] ht)
    {
        // code here
        int n = ht.Length; // 4

        if (n == 1) return 0;

        int[] dp = new int[n];

        dp[0] = 0;
        dp[1] = Math.Abs(ht[1] - ht[0]);

        if (n == 2) return dp[1];

        for (int i = 2; i < n; i++)
        {
            int h1 = dp[i - 1] + Math.Abs(ht[i] - ht[i - 1]);
            int h2 = dp[i - 2] + Math.Abs(ht[i] - ht[i - 2]);
            dp[i] = Math.Min(h1, h2);
        }

        return dp[n - 1];
    }
}