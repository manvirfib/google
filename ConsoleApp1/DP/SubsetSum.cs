class isSubsetSumSolution
{
    int Rec(int idx, int cur, int[] arr, int[][] dp)
    {
        if (cur == arr[idx]) return 1;

        if (idx == 0)
        {
            return 0;
        }

        if (dp[idx][cur] != -1) return dp[idx][cur];

        int noTaken = Rec(idx - 1, cur, arr, dp);
        int taken = 0;

        if (cur >= arr[idx])
            taken = Rec(idx - 1, cur - arr[idx], arr, dp);

        return dp[idx][cur] = taken | noTaken;
    }

    public bool isSubsetSum(int[] arr, int target)
    {
        int m = arr.Length;
        int[][] dp = new int[m][];

        for (int i = 0; i < m; i++)
        {
            dp[i] = new int[target];
            Array.Fill(dp[i], -1);
        }
        return Rec(m - 1, target, arr, dp) == 1;
    }
}
//Memoization;
