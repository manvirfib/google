public class UniquePathsASolution {
    int Rec(int m, int n, int[,] dp){
        if(m == 0 || n == 0) return 1;
        if(dp[m, n] != -1) return dp[m, n];
        return dp[m, n] = Rec(m - 1, n, dp) + Rec(m, n - 1, dp);
    }
    public int UniquePaths(int m, int n) {
        int[,] dp = new int[m, n];
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                dp[i, j] = -1;
            }
        }
        return Rec(m - 1, n - 1, dp);
    }
}