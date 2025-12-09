public class MinCostClimbingStairsSolution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;
        int[] dp = new int[n + 1];
        if(n < 2) return 0;
        dp[0] = cost[0];
        dp[1] = cost[1];

        for(int idx = 2; idx < n; idx++){
            dp[idx] = cost[idx] + Math.Min(dp[idx - 1], dp[idx - 2]);
        }

        return Math.Min(dp[n - 1], dp[n - 2]);
    }
}
