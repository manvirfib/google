public class PartitionSubsetSumSolution {
    int Rec(int idx, int am, int[] nums, int[,] dp){
        if(idx == 0){
            if(am == 0 || am == nums[idx]) return 1;
            return 0;
        }
        if(dp[idx, am] != -1) return dp[idx, am];
        int notTake = Rec(idx - 1, am, nums, dp);
        int take = 0;
        if(am >= nums[idx]){
            take = Rec(idx - 1, am - nums[idx], nums, dp);
        }

        return dp[idx, am] = notTake | take;
    }
    public bool CanPartition(int[] nums) {
        int sum = nums.Sum();
        int n = nums.Length;
        if(sum % 2 == 1) return false;

        int total = sum / 2;

        int[,] dp = new int[n + 1, total + 1];

        for(int i = 0; i <= n; i++){
            for(int j = 1; j <= total; j++){
                dp[i, j] = -1;
            }
        }

        return Rec(n - 1, total, nums, dp) == 1;
    }
}
