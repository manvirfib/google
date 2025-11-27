class RodCuttingSolution {
    int Rec(int idx, int cuts, int[] price, int[][] dp){
        if(idx == 0){
            if(cuts >= 1) return price[0]*cuts;
            return 0;
        }
        
        if(dp[idx][cuts] != -1) return dp[idx][cuts];
        
        int notCut = Rec(idx - 1, cuts, price, dp);
        int cut = 0;
        
        if((idx+1) <= cuts){
            cut = price[idx] + Rec(idx, cuts - idx - 1, price, dp);
        }
        
        return dp[idx][cuts] = Math.Max(notCut, cut);
    }
    
    public int cutRod(int[] price) {
        int n = price.Length;
        int[][] dp = new int[n][];
        
        for(int i = 0; i < n; i++){
            dp[i] = new int[n + 1];
            Array.Fill(dp[i], -1);
        }
        
        return Rec(n - 1, n, price, dp);
    }
}