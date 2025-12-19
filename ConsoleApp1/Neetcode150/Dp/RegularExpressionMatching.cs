public class IsMatchRegularExpressionHardSolution {
    int Rec(int i, int j, string s, string p, int[,] dp){
        if(i >= s.Length && j >= p.Length) return 1;
        if(j >= p.Length) return 0;
        if(dp[i, j] != -1) return dp[i, j];
        int match = 0;
        if(i < s.Length && (s[i] == p[j] || p[j] == '.')) match = 1;

        if(j + 1 < p.Length && p[j + 1] == '*'){
            int notTake = Rec(i, j + 2, s, p, dp);
            int take = 0;
            if(match == 1){
                take = Rec(i + 1, j, s, p, dp);
            }
            return dp[i, j] = take | notTake;
        }
        if(match == 1) return dp[i, j] = Rec(i + 1, j + 1, s, p, dp);
        return dp[i, j] = 0;
    }
    public bool IsMatch(string s, string p) {
        int n1 = s.Length, n2 = p.Length;
        int[,] dp = new int[n1 + 1, n2 + 1];
        for(int i = 0; i <= n1; i++){
            for(int j = 0; j <= n2; j++){
                dp[i, j] = -1;
            }
        }
        return Rec(0, 0, s, p, dp) == 1;
    }
}