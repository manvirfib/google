class MatrixChainMultiplicationSolution {
    public int matrixMultiplication(int[] arr) {
        int n = arr.Length;
        int[,] dp = new int[n, n];
        
        for(int i = n - 1; i >= 1; i--){
            for(int j = i + 1; j < n; j++){
                int min = int.MaxValue;
                for(int k = i; k < j; k++){
                    int steps = arr[i - 1] * arr[k] * arr[j] + dp[i, k] + dp[k + 1, j];
                    min = Math.Min(min, steps);
                }
                dp[i, j] = min;
            }
        }
        
        return dp[1, n - 1];
    }
}