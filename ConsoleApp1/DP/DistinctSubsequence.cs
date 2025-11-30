public class DistinctSubsequenceSolution {
    int Rec(int i, int j, string s, string t, int[,] dp){
        if(j == 0) return 1;
        if(i == 0) return 0;
        if(dp[i, j] != -1) return dp[i, j];
        if(s[i - 1] == t[j - 1]){
            return dp[i, j] = Rec(i - 1, j - 1, s, t, dp) + Rec(i - 1, j, s, t, dp);
        }
        else{
            return dp[i, j] = Rec(i - 1, j, s, t, dp);
        }
    }
    public int NumDistinct(string s, string t) {
        int n1 = s.Length;
        int n2 = t.Length;
        int[,] dp = new int[n1 + 1, n2 + 1];

        for(int i = 0; i <= n1; i++){
            dp[i, 0] = 1;
        }
        for(int i = 1; i <= n1; i++){
            for(int j = 1; j <= n2; j++){
                if(s[i - 1] == t[j - 1]){
                    dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
                }
                else{
                    dp[i, j] = dp[i - 1, j];
                }
            }
        }

        return dp[n1, n2];
    }
}