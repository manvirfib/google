public class WildCardTabulationSolution {
    public bool IsMatch(string s, string p) {
        int n1 = s.Length;
        int n2 = p.Length;
        bool[,] dp = new bool[n1 + 1, n2 + 1];

        dp[0, 0] = true;

        for(int i2 = 1; i2 <= n2; i2++){
            if(p[i2 - 1] == '*')
            dp[0, i2] = dp[0, i2 - 1];
        }

        for(int i1 = 1; i1 <= n1; i1++){
            for(int i2 = 1; i2 <= n2; i2++){
                if(s[i1 - 1] == p[i2 - 1] || p[i2 - 1] == '?'){
                    dp[i1, i2] = dp[i1 - 1, i2 - 1];
                }
                else if(p[i2 - 1] == '*') dp[i1, i2] = dp[i1, i2 - 1] || dp[i1 - 1, i2];
            }
        }

        return dp[n1, n2];
    }
}