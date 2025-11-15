public class HouseRobber2 {
    public int Rob(int[] nums) {
        int n = nums.Length;
        int[] dp1 = new int[n];
        dp1[0] = nums[0];

        if(n == 2){
            return Math.Max(nums[0], nums[1]);
        }

        if(n == 1) return nums[0];

        int[] dp2 = new int[n];

        for(int i = 1; i < n; i++){
            int pick1 = nums[i];
            int pick2 = nums[i];

            if(i > 1) pick1 += dp1[i - 2];
            int npick1 = dp1[i - 1];
            dp1[i] = Math.Max(pick1, npick1);

            if(i > 1) pick2 += dp2[i - 2];
            int npick2 = dp2[i - 1];
            dp2[i] = Math.Max(pick2, npick2);
        }

        return Math.Max(dp1[n - 2], dp2[n - 1]);
    }
}