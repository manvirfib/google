public class EditDistanceEasySolution {
    int Rec(int i, int j, string wd1, string wd2, int[,] dp){
        if(j == 0){
            return i;
        }
        if(i == 0){
            return j;
        }
        if(dp[i, j] != -1) return dp[i, j];
        if(wd1[i - 1] == wd2[j - 1]){
            return dp[i, j] = Rec(i - 1, j - 1, wd1, wd2, dp);
        }
        int iop = 1 + Rec(i, j - 1, wd1, wd2, dp);
        int dop = 1 + Rec(i - 1, j, wd1, wd2, dp);
        int rop = 1 + Rec(i - 1, j - 1, wd1, wd2, dp);

        return dp[i, j] = Math.Min(iop, Math.Min(dop, rop));
    }
    public int MinDistance(string word1, string word2) {
        int n1 = word1.Length;
        int n2 = word2.Length;
        int[,] dp = new int[n1 + 1, n2 + 1];
        for(int i = 0; i <= n1; i++){
            for(int j = 0; j <= n2; j++){
                dp[i, j] = -1;
            }
        }
        return Rec(n1, n2, word1, word2, dp);
    }
}
