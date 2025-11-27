public class CountPartitionsSolution {
    public int countPartitions(int[] arr, int diff) {
        int n = arr.Length;
        int sum = arr.Sum();
        
        if((sum - diff < 0) || (sum + diff) % 2 != 0) return 0;
        int target = (sum + diff)/2;
        
        int[,] dp = new int[n, target + 1];
        
        if(arr[0] == 0) dp[0, 0] = 2;
        else{
            dp[0, 0] = 1;
        }
        if(arr[0] != 0 && arr[0] <= target)
            dp[0, arr[0]] = 1;
        
        for(int i = 1; i < n; i++){
            for(int j = 0; j <= target; j++){
                int notaken = dp[i - 1, j];
                int taken = 0;
                
                if(arr[i] <= j){
                    taken = dp[i - 1, j - arr[i]];
                }
                
                dp[i, j] = taken + notaken;
            }
        }
        
        return dp[n - 1, target];
    }
}