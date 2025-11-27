public class TargetSum {
    int Rec(int idx, int target, int[] nums, int[][] dp, int offset){
        if (Math.Abs(target) > offset) return 0;
        if(idx < 0){
            if(target == 0) return 1;
            return 0;
        }
        if(dp[idx][target + offset] != -1) return dp[idx][target + offset];

        int pTaken = Rec(idx - 1, target - nums[idx], nums, dp, offset);
        int nTaken = Rec(idx - 1, target + nums[idx], nums, dp, offset);

        return dp[idx][target + offset] = pTaken + nTaken;
    }
    public int FindTargetSumWays(int[] nums, int target) {
        int n = nums.Length;
        int sum = nums.Sum();
        int size = 2 * sum + 1;

        int[][] dp = new int[n][];
        
        if(Math.Abs(target) > sum) return 0;

        for(int i = 0; i < n; i++){
            dp[i] = new int[size];
            Array.Fill(dp[i], -1);
        }

        return Rec(n - 1, target, nums, dp, sum);
    }
}