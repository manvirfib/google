public class LISSolution {
    int Rec(int idx, int prev, int[] nums, int[,] dp){
        if(idx == nums.Length) return 0;
        if(dp[idx, prev + 1] != -1) return dp[idx, prev + 1];
        int notTake = Rec(idx + 1, prev, nums, dp);
        int take = 0;
        if(prev == -1 || nums[idx] > nums[prev]){
            take = 1 + Rec(idx + 1, idx, nums, dp);
        }

        return dp[idx, prev + 1] = Math.Max(notTake, take);
    }
    public int LengthOfLIS(int[] nums) {
        int n = nums.Length;
        int[,] dp = new int[n + 1, n + 1];
        for(int i = 0; i <= n; i++){
            for(int j = 0; j <= n; j++){
                dp[i, j] = -1;
            }
        }
        return Rec(0, -1, nums, dp);
    }
}
