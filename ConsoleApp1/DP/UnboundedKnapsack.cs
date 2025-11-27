class UnboundedKnapsack {
    public int knapSack(int[] val, int[] wt, int capacity) {
        int n = val.Length;
        int[,] dp = new int[n, capacity + 1];
        
        for(int i = 0; i <= capacity; i++){
            if(i >= wt[0]){
                dp[0, i] = val[0] * (i / wt[0]);
            }
        }
        
        for(int i = 1; i < n; i++){
            for(int j = 0; j <= capacity; j++){
                int notPick = dp[i - 1, j];
                int pick = 0;
                
                if(wt[i] <= j){
                    pick = val[i] + dp[i, j - wt[i]];
                }
                
                dp[i, j] = Math.Max(pick, notPick);
            }
        }
        
        return dp[n - 1, capacity];
    }
}