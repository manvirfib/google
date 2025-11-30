public class ShortestCommonSupersequenceSolution {
    public string ShortestCommonSupersequence(string text1, string text2) {
        int n1 = text1.Length;
        int n2 = text2.Length;
        int[][] dp = new int[n1 + 1][];

        for(int i = 0; i <= n1; i++){
            dp[i] = new int[n2 + 1];
        }

        for(int i = 0; i <= n1; i++){
            dp[i][0] = 0;
        }

        for(int i = 0; i <= n2; i++){
            dp[0][i] = 0;
        }

        for(int i = 1; i <= n1; i++){
            for(int j = 1; j <= n2; j++){
                if(text1[i - 1] == text2[j - 1]){
                    dp[i][j] = 1 + dp[i - 1] [j - 1];
                }
                else dp[i][j] = Math.Max(dp[i - 1][j], dp[i][j - 1]);
            }
        }

        string result = "";
        int i1 = n1, j1 = n2;

        while(i1 > 0 && j1 > 0){
            if(text1[i1 - 1] == text2[j1 - 1]){
                result = text1[i1 - 1] + result;
                i1--;
                j1--;
            }
            else if(dp[i1][j1 - 1] > dp[i1 - 1][j1]){
                result = text2[j1 - 1] + result;
                j1--;
            }
            else{
                result = text1[i1 - 1] + result;
                i1--;
            }
        }

        while(i1 > 0){
            result = text1[i1 - 1] + result;
            i1--;
        }
        while(j1 > 0){
            result = text2[j1 - 1] + result;
            j1--;
        }

        return result;
    }
}