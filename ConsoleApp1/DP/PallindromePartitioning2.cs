public class MinCutSolution {
    bool IsPal(string s){
        for(int i = 0, j = s.Length - 1; i < j; i++, j--){
            if(s[i] != s[j]) return false;
        }

        return true;
    }
    int Rec(int i, string s, int[] dp){
        if(i == s.Length) return 0;
        int min = int.MaxValue;
        if(dp[i] != -1) return dp[i];
        for(int a = i; a < s.Length; a++){
            if(IsPal(s.Substring(i, a - i + 1))){
                int div = 1 + Rec(a + 1, s, dp);
                min = Math.Min(div, min);
            }
        }
        return dp[i] = min;
    }
    public int MinCut(string s) {
        int n = s.Length;
        if(s == "") return 0;
        int[] dp = new int[n + 1];

        Array.Fill(dp, -1);

        return Rec(0, s, dp) - 1;
    }
}