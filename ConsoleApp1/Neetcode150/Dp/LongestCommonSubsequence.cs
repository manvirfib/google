public class LongestCommonSubsequenceSolution {
    int Rec(int i, int j, string s1, string s2, int[,] dp){
        if(i < 0 || j < 0) return 0;
        int eq1 = 0, eq2 = 0;
        if(dp[i, j] != -1) return dp[i, j];
        if(s1[i] == s2[j]){
            eq1 = 1 + Rec(i - 1, j - 1, s1, s2, dp);
        }
        else{
            eq2 = Math.Max(Rec(i - 1, j, s1, s2, dp), Rec(i, j - 1, s1, s2, dp));
        }
        return dp[i, j] = Math.Max(eq1, eq2);
    }
    public int LongestCommonSubsequence(string t1, string t2) {
        int n1 = t1.Length;
        int n2 = t2.Length;
        int[,] dp = new int[n1, n2];

        for(int i = 0; i < n1; i++){
            for(int j = 0; j < n2; j++){
                dp[i, j] = -1;
            }
        }

        return Rec(n1 - 1, n2 - 1, t1, t2, dp);
    }
}