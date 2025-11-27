public class RodCuttingTabulationSolution {
    public int cutRod(int[] price) {
        int n = price.Length;
        int[,] dp = new int[n, n + 1];

        // Base case: when only piece of length 1 is allowed
        for (int j = 0; j <= n; j++) {
            dp[0, j] = price[0] * j;
        }

        for (int i = 1; i < n; i++) {
            for (int j = 0; j <= n; j++) {
                int notCut = dp[i - 1, j];
                int cut = 0;

                if ((i + 1) <= j) {
                    cut = price[i] + dp[i, j - (i + 1)];
                }

                dp[i, j] = Math.Max(notCut, cut);
            }
        }

        return dp[n - 1, n];
    }
}
