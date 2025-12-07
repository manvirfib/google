public class BurstBallonsSolution {
    int Rec(int i, int j, int[] arr, int[,] dp){
        if(i > j) return 0;
        int max = 0;

        if(dp[i, j] != -1) return dp[i, j];
        for(int k = i; k <= j; k++){
            int temp = arr[i - 1] * arr[k] * arr[j + 1] + Rec(i, k - 1, arr, dp) + Rec(k + 1, j, arr, dp);
            max = Math.Max(max, temp);
        }

        return dp[i, j] = max;
    }
    public int MaxCoins(int[] nums) {
        int len = nums.Length;
        int[] arr = new int[len + 2];
        int[,] dp = new int[len + 2, len + 2];
        for(int i = 1; i <= len; i++){
            arr[i] = nums[i - 1];
        }
        for(int i = 0; i <= len + 1; i++){
            for(int j = 0; j <= len + 1; j++){
                dp[i, j] = -1;
            }
        }
        arr[0] = 1;
        arr[len + 1] = 1;

        return Rec(1, len, arr, dp);
    }
}