public class ClimbStairsSolution {
    public int ClimbStairs(int n) {    
        int[] dp = new int[n + 2];
        dp[1] = 1;
        for(int idx = 2; idx < (n + 2); idx++){
            dp[idx] = dp[idx - 1] + dp[idx - 2];
        }
        return dp[n + 1];
    }
}
