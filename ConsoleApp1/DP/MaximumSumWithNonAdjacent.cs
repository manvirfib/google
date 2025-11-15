class MaximumSum {
    public int FindMaxSum(int[] arr) {
        int n = arr.Length;
        int[] dp = new int[n];
        
        dp[0] = arr[0];
        
        for(int i = 1; i < n; i++){
            int pick = arr[i];
            if(i > 1){
                pick = pick + dp[i - 2];
            }
            int npick = dp[i - 1];
            dp[i] = Math.Max(pick, npick);
        }
        
        return dp[n - 1];
    }
}
