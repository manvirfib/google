public class WordBreakSolution {
    int Rec(int idx, int prev, HashSet<string> wD, string s, int[,] dp){
        if(idx == 0){
            string temp = s.Substring(idx, prev - idx + 1);
            if(wD.Contains(temp)) return 1;
            return 0;
        }

        if(dp[idx, prev] != -1) return dp[idx, prev]; 

        string str = s.Substring(idx, prev - idx + 1);
        int brek = 0;

        if(wD.Contains(str))
        brek = Rec(idx - 1, idx - 1, wD, s, dp);

        int notBreak = Rec(idx - 1, prev, wD, s, dp);

        return dp[idx, prev] = brek | notBreak;
    }
    public bool WordBreak(string s, List<string> wi) {
        HashSet<string> wordDict = new(wi);
        int n = s.Length;
        int[,] dp = new int[n + 1, n + 1];

        for(int idx = 0; idx <= n; idx++){
            for(int prev = 0; prev <= n; prev++){
                dp[idx, prev] = -1;
            }
        }

        return Rec(n - 1, n - 1, wordDict, s, dp) == 1;
    }
}
