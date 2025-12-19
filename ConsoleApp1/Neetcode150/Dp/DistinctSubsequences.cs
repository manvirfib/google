public class NumDistinctSolution {
    int Rec(int i, int j, string s, string t, int[,] dp){
        if(j < 0) return 1;
        if(i < 0) return 0;
        if(dp[i, j] != -1) return dp[i, j];
        int take = 0;
        if(s[i] == t[j]){
            take = Rec(i - 1, j - 1, s, t, dp);
        }
        return dp[i, j] = take + Rec(i - 1, j, s, t, dp);
    }
    public int NumDistinct(string s, string t) {
        int n = s.Length;
        int m = t.Length;
        int[,] dp = new int[n, m];
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++){
                dp[i, j] = -1;
            }
        }
        return Rec(n - 1, m - 1, s, t, dp);
    }
}
