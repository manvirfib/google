public class IsInterleaveSolution {
    int Rec(int i, int j, int k, string s1, string s2, string s3, int[,,] dp){
        if(i == s1.Length && j == s2.Length){
            if(k == s3.Length) return 1;
            return 0;
        }
        if(dp[i, j, k] != -1) return dp[i, j, k];
        int fs = 0, ss = 0;
        if(i < s1.Length && s1[i] == s3[k]){
            fs = Rec(i + 1, j, k + 1, s1, s2, s3, dp);
        }
        if(j < s2.Length && s2[j] == s3[k]){
            ss = Rec(i, j + 1, k + 1, s1, s2, s3, dp);
        }
        
        return dp[i, j, k] = fs | ss;
    }
    public bool IsInterleave(string s1, string s2, string s3) {
        int n1 = s1.Length, n2 = s2.Length, n3 = s3.Length;
        if(n1 + n2 != n3) return false;
        int[,,] dp = new int[n1 + 1, n2 + 1, n3 + 1];

        for(int i = 0; i <= n1; i++){
            for(int j = 0; j <= n2; j++){
                for(int k = 0; k <= n3; k++){
                    dp[i, j, k] = -1;
                }
            }
        }
        return Rec(0, 0, 0, s1, s2, s3, dp) == 1;
    }
}