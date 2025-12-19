public class FindTargetSumWaysSolution {
    int Rec(int idx, int am, int[] nums, int[,] dp, int offset){
        if (am < -offset || am > offset) return 0;
        if(idx == 0){
            if(am + nums[0] == 0 && am - nums[0] == 0) return 2;
            if(am + nums[0] == 0 || am - nums[0] == 0) return 1;
            return 0;
        }

        if(dp[idx, am + offset] != -1) return dp[idx, am + offset];

        int pos = Rec(idx - 1, am + nums[idx], nums, dp, offset);
        int neg = Rec(idx - 1, am - nums[idx], nums, dp, offset);

        return dp[idx, am + offset] = pos + neg;
    }
    public int FindTargetSumWays(int[] nums, int target) {
        int n = nums.Length;
        int sum = nums.Sum();
        int size = 2 * sum + 1;
        int[,] dp = new int[n + 1, size + 1];

        for(int i = 0; i < n; i++){
            for(int j = 0; j <= size; j++){
                dp[i, j] = -1;
            }
        }

        return Rec(n - 1, target, nums, dp, sum);
    }
}
