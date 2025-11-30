public class EditDistanceSolution {
    int Rec(int i1, int i2, string w1, string w2, int[,] dp){
        if(i1 == 0) return i2 + 1;
        if(i2 == 0) return i1 + 1;
        if(dp[i1, i2] != -1) return dp[i1, i2];
        if(w1[i1 - 1] == w2[i2 - 1]){
            return Rec(i1 - 1, i2 -1, w1, w2, dp);
        }
        return dp[i1, i2] = 1 + Math.Min(Rec(i1 - 1, i2 - 1, w1, w2, dp), Math.Min(Rec(i1, i2 - 1, w1, w2, dp), Rec(i1 - 1, i2, w1, w2, dp)));
    }
    public int MinDistance(string w1, string w2) {
        int n1 = w1.Length;
        int n2 = w2.Length;
        int[,] dp = new int[n1 + 1, n2 + 1];

        for(int i = 0; i <= n2; i++){
            dp[0, i] = i + 1;
        }
        for(int i = 0; i <= n1; i++){
            dp[i, 0] = i + 1;
        }

        for(int i1 = 1; i1 <= n1; i1++){
            for(int i2 = 1; i2 <= n2; i2++){
                if(w1[i1 - 1] == w2[i2 - 1]){
                    dp[i1, i2] = dp[i1 - 1, i2 -1];
                }
                else dp[i1, i2] = 1 + Math.Min(dp[i1 - 1, i2 - 1], Math.Min(dp[i1, i2 - 1], dp[i1 - 1, i2]));
            }
        }

        return dp[n1, n2] - 1;
    }
}