public class WildCardMatchingSolution {
    int Rec(int i1, int i2, string s, string p, int[,] dp){
        if(i1 == 0 && i2 == 0) return 1;
        if(i2 == 0) return 0;
        if(i1 == 0){
            if(p[i2 - 1] == '*') return Rec(i1, i2 - 1, s, p, dp);
            return 0;
        }
        if(dp[i1, i2] != -1) return dp[i1, i2];
        if(s[i1 - 1] == p[i2 - 1] || (p[i2 - 1] == '?' && i1 >= 0)){
            return dp[i1, i2] = Rec(i1 - 1, i2 - 1, s, p, dp);
        }
        if(p[i2 - 1] == '*') return dp[i1, i2] = Rec(i1, i2 - 1, s, p, dp) | Rec(i1 - 1, i2, s, p, dp);
        return 0;
    }
    public bool IsMatch(string s, string p) {
        int n1 = s.Length;
        int n2 = p.Length;
        int[,] dp = new int[n1 + 1, n2 + 1];

        for(int i1 = 0; i1 <= n1; i1++){
            for(int i2 = 0; i2 <= n2; i2++){
                dp[i1, i2] = -1;
            }
        }

        return Rec(n1, n2, s, p, dp) == 1;
    }
}