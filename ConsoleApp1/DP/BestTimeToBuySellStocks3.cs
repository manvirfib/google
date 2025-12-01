public class SellStocks3Solution {
    int Rec(int idx, int buy, int cap, int[] prices, int[,,] dp){
        if(cap == 0 || idx == prices.Length) return 0;
        if(dp[idx, buy, cap] != -1) return dp[idx, buy, cap];
        if(buy == 1){
            int take = -prices[idx] + Rec(idx + 1, 0, cap, prices, dp);
            int notTake = Rec(idx + 1, 1, cap, prices, dp);
            return dp[idx, buy, cap] = Math.Max(take, notTake);
        }
        else{
            int sell = prices[idx] + Rec(idx + 1, 1, cap - 1, prices, dp);
            int notSell = Rec(idx + 1, 0, cap, prices, dp);
            return dp[idx, buy, cap] = Math.Max(sell, notSell);
        }
    }
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int capacity = 2;
        int[,,] dp = new int[n + 1, 2, capacity + 1];

        for(int idx = 0; idx <= n; idx++){
            for(int buy = 0; buy < 2; buy++){
                for(int cap = 0; cap <= capacity; cap++){
                    dp[idx, buy, cap] = -1;
                }
            }
        }

        return Rec(0, 1, capacity, prices, dp);
    }
}