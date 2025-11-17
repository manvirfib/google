public class UniquePaths2 {
    public int UniquePathsWithObstacles(int[][] og) {
        int m = og.Length;
        int n = og[0].Length;
        int[,] dp = new int[m, n];

        if(og[0][0] == 1) return 0;

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(i == 0 && j == 0){
                    dp[i, j] = 1;
                    continue;
                } 
                int u = 0, d = 0;
                if(og[i][j] == 1) continue;
                if(i > 0) u = dp[i - 1, j];
                if(j > 0) d = dp[i, j - 1];

                dp[i, j] = u + d;
            }
        }

        return dp[m - 1, n - 1];
    }
}