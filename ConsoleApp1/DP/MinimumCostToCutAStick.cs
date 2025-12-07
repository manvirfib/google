public class MinCostSolution {
    int Rec(int i, int j, int[] arr, int[,] dp){
        if(i > j) return 0;
        int min = (int)1e9;

        if(dp[i, j] != -1) return dp[i, j];
        for(int k = i; k <= j; k++){
            int cost = arr[j + 1] - arr[i - 1] + Rec(i, k - 1, arr, dp) + Rec(k + 1, j, arr, dp);
            min = Math.Min(min, cost);
        }

        return dp[i, j] = min;
    }
    public int MinCost(int n, int[] cuts) {
        Array.Sort(cuts);
        int len = cuts.Length;
        int[] arr = new int[len + 2];
        int[,] dp = new int[len + 2, len + 2];

        for(int i = 0; i < len + 2; i++){
            for(int j = 0; j < len + 2; j++){
                dp[i, j] = -1;
            }
        }

        for(int i = 1; i <= len; i++){
            arr[i] = cuts[i - 1];
        }

        arr[len + 1] = n;

        return Rec(1, len, arr, dp);
    }
}