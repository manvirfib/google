public class NumDecodingsSolution {
    public int NumDecodings(string s) {
        int n = s.Length;
        int[] dp = new int[n + 2];
        dp[n] = dp[n + 1] = 1;

        for(int idx = n - 1; idx >= 0; idx--){
            int ways = dp[idx + 1];

            if (s[idx] == '0') {
                dp[idx] = 0;
                continue;
            }
            
            if(idx + 1 < n){
                int val = (s[idx] - '0') * 10 + (s[idx + 1] - '0');
                if (val <= 26) {
                    ways += dp[idx + 2];
                }
            }
            dp[idx] = ways;
        }

        return dp[0];
    }
}
