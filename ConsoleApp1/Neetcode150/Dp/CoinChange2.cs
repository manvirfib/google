public class CC2Solution {
    int Rec(int idx, int am, int[] coins, int[,] dp){
        if(am == 0) return 1;
        if(idx == 0){
            if(am % coins[0] == 0) return 1;
            return 0;
        }
        if(dp[idx, am] != -1) return dp[idx, am];
        int notTake = Rec(idx - 1, am, coins, dp);
        int take = 0;

        if(am >= coins[idx]){
            take = Rec(idx, am - coins[idx], coins, dp);
        }

        return dp[idx, am] = take + notTake;
    }
    
    public int Change(int amount, int[] coins) {
        int n = coins.Length;
        int[,] dp = new int[n, amount + 1];
        for(int idx = 0; idx < n; idx++){
            for(int am = 0; am <= amount; am++){
                dp[idx, am] = -1;
            }
        }

        return Rec(n - 1, amount, coins, dp);
    }
}
