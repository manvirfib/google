// User function Template for C#

class longestCommonSubstrSolution {
    // Complete this function
    public int longestCommonSubstr(string s1, string s2) {
        int n1 = s1.Length, n2 = s2.Length;
        int[,] dp = new int[n1 + 1, n2 + 1];
        int max = 0;
        
        for(int i = 1; i <= n1; i++){
            for(int j = 1; j <= n2; j++){
                if(s1[i - 1] == s2[j - 1]){
                    dp[i, j] = 1 + dp[i - 1, j - 1];
                    max = Math.Max(dp[i, j], max);
                }
                else{
                    dp[i, j] = 0;
                }
            }
        }
        
        return max;
    }
}