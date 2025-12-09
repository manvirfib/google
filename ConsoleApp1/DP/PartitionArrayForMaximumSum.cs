public class MaxSumAfterPartitioningSolution {
    int Rec(int idx, int c, int[] arr, int[] dp){
        if(idx == arr.Length) return 0;
        int cmax = arr[idx];
        int max = 0;
        if(dp[idx] != -1) return dp[idx];
        for(int i = idx; (i < idx + c) && (i < arr.Length); i++){
            cmax = Math.Max(cmax, arr[i]);
            int temp = cmax * (i - idx + 1) + Rec(i + 1, c, arr, dp);
            max = Math.Max(temp, max);
        }

        return dp[idx] = max;
    }
    public int MaxSumAfterPartitioning(int[] arr, int k) {
        int n = arr.Length;
        int[] dp = new int[n + 1];
        Array.Fill(dp, -1);

        return Rec(0, k, arr, dp);
    }
}