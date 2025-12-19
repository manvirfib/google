public class MaxProfitStockSolution {
    int Rec(int idx, int buy, int[] prices, int[,] dp){
        if(idx >= prices.Length) return 0;

        if(dp[idx, buy] != -1) return dp[idx, buy];

        if(buy == 0){
            int take = -prices[idx] + Rec(idx + 1, 1, prices, dp);
            int notTake = Rec(idx + 1, buy, prices, dp);
            return dp[idx, buy] = Math.Max(take, notTake);
        }
        else{
            int sell = prices[idx] + Rec(idx + 2, 0, prices, dp);
            int notSell = Rec(idx + 1, buy, prices, dp);
            return dp[idx, buy] = Math.Max(sell, notSell);
        }
    }
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int[,] dp = new int[n, 2];

        for(int i = 0; i < n; i++){
            dp[i, 0] = dp[i, 1] = -1;
        }

        return Rec(0, 0, prices, dp);
    }
}