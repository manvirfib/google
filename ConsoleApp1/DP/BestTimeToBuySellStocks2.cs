public class MaxProfitSolution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int[,] dp = new int[n + 1, 2];

        for(int idx = n - 1; idx >= 0; idx--){
            for(int buy = 0; buy <= 1; buy++){
                if(buy == 1){
                    int take = -prices[idx] + dp[idx + 1, 0];
                    int notTake = dp[idx + 1, 1];
                    dp[idx, buy] = Math.Max(take, notTake);
                }
                else{
                    int sell = prices[idx] + dp[idx + 1, 1];
                    int notSell = dp[idx + 1, 0];
                    dp[idx, buy] = Math.Max(sell, notSell);
                }
            }
        }

        return dp[0, 1];
    }
}