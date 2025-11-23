public class MinFallingPathSumSolution {
    public int MinFallingPathSum(int[][] matrix) {
        int n = matrix.Length;

        for(int i = n - 2; i >= 0; i--){
            for(int j = 0; j < n; j++){
                int s = matrix[i + 1][j];
                int left = int.MaxValue, right = int.MaxValue;
                if(j > 0) left = matrix[i + 1][j - 1];
                if(j < (n - 1)) right = matrix[i + 1][j + 1];

                matrix[i][j] = Math.Min(s, Math.Min(left, right)) + matrix[i][j];
            }
        }

        int min = int.MaxValue;

        for(int i = 0; i < n; i++){
            if(min > matrix[0][i]) min = matrix[0][i];
        }
        
        return min;
    }
}