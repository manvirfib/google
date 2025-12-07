public class BuyAndSellSolution {
    int Rec(int idx, int buy, int fee, int[] prices, int[,] dp){
        if(idx == prices.Length) return 0;

        if(dp[idx, buy] != -1) return dp[idx, buy];
        
        if(buy == 1){
            int take = -prices[idx] + Rec(idx + 1, 0, fee, prices, dp);
            int notTake = Rec(idx + 1, 1, fee, prices, dp);
            return dp[idx, buy] = Math.Max(take, notTake);
        }
        else{
            int sell = prices[idx] - fee + Rec(idx + 1, 1, fee, prices, dp);
            int notSell = Rec(idx + 1, 0, fee, prices, dp);
            return dp[idx, buy] = Math.Max(sell, notSell);
        }
    }
    public int MaxProfit(int[] prices, int fee) {
        int n = prices.Length;
        int[,] dp = new int[n, 2];

        for(int i = 0; i < n; i++){
            dp[i, 0] = -1;
            dp[i, 1] = -1;
        }

        return Rec(0, 1, fee, prices, dp);
    }
}