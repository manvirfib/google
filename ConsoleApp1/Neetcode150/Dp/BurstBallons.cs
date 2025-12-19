public class BurstBallonsMediumSolution {
    int Rec(int i, int j, int[] nums, int[,] dp){
        if(i > j) return 0;
        if(dp[i, j] != -1) return dp[i, j];
        int max = 0;

        for(int k = i; k <= j; k++){
            int curB = nums[i - 1] * nums[k] * nums[j + 1] + Rec(i, k - 1, nums, dp) + Rec(k + 1, j, nums, dp);
            max = Math.Max(max, curB);
        }

        return dp[i, j] = max;
    }
    public int MaxCoins(int[] nums) {
        int n = nums.Length;
        int[] arr = new int[n + 2];

        for(int i = 1; i <= n; i++){
            arr[i] = nums[i - 1];
        }

        arr[0] = arr[n + 1] = 1;

        int[,] dp = new int[n + 2, n + 2];

        for(int i = 0; i <= n + 1; i++){
            for(int j = 0; j <= n + 1; j++){
                dp[i, j] = -1;
            }
        }

        return Rec(1, n, arr, dp);
    }
}
