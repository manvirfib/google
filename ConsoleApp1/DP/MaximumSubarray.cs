public class MaxSubArraySolution {
    int Rec(int idx, int flag, int[] nums, int[,] dp){
        if(idx == nums.Length){
            return flag == 1 ? 0 : (int)-(1e9);
        }
        if(dp[idx, flag] != -1) return dp[idx, flag];
        if(flag == 1) return dp[idx, flag] = Math.Max(0, nums[idx] + Rec(idx + 1, 1, nums, dp));
        return dp[idx, flag] = Math.Max(nums[idx] + Rec(idx + 1, 1, nums, dp), Rec(idx + 1, 0, nums, dp));
    }
    public int MaxSubArray(int[] nums) {
        int[,] dp = new int[nums.Length, 2];
        for(int i = 0; i < nums.Length; i++){
            dp[i, 0] = -1;
            dp[i, 1] = -1;
        }
        return Rec(0, 0, nums, dp);
    }
}
