public class HouseRobber {
    public int Rob(int[] nums) {
        int n = nums.Length;
        int[] dp = new int[n];
        dp[0] = nums[0];

        for(int i = 1; i < n; i++){
            int pick = nums[i];
            if(i > 1) pick += dp[i - 2];
            int npick = dp[i - 1];
            dp[i] = Math.Max(pick, npick);
        }

        return dp[n - 1];
    }
}