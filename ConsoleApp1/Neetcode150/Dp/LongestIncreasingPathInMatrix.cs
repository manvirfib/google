public class LongestIncreasingPathSolution {
    int[] dirx = { 1, 0, -1, 0 };
    int[] diry = { 0, 1, 0, -1 };
    int m, n;
    int[,] dp;
    int Rec(int i, int j, int[][] matrix){
        int max = 0;
        if(dp[i, j] != -1) return dp[i, j];
        for(int k = 0; k < 4; k++){
            int x = i + dirx[k];
            int y = j + diry[k];
            if(x >= 0 && y >= 0 && x < m && y < n && matrix[i][j] < matrix[x][y]){
                max = Math.Max(max, 1 + Rec(x, y, matrix));
            }
        }
        return dp[i, j] = max;
    }
    public int LongestIncreasingPath(int[][] matrix) {
        int max = 0;
        m = matrix.Length;
        n = matrix[0].Length;
        dp = new int[m, n];

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                dp[i, j] = -1;
            }
        }

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                max = Math.Max(max, 1 + Rec(i, j, matrix));
            }
        }

        return max;
    }
}