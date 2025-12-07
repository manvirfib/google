public class SellStocksSolution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int[,] dp = new int[n + 2, 2];

        for(int idx = n - 1; idx >= 0; idx--){
            for(int buy = 0; buy < 2; buy++){
                if(buy == 0){
                    int take = -prices[idx] + dp[idx + 1, 1];
                    int notTake = dp[idx + 1, buy];
                    dp[idx, buy] = Math.Max(take, notTake);
                }
                else{
                    int sell = prices[idx] + dp[idx + 2, 0];
                    int notSell = dp[idx + 1, buy];
                    dp[idx, buy] = Math.Max(sell, notSell);
                }
            }
        }

        return dp[0, 0];
    }
}