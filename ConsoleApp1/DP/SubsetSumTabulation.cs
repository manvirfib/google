public class SubsetSolution
{
    int Rec(int idx, int cur, int[] arr, int[][] dp)
    {
        if (cur == 0) return 1;        // Sum found
        if (idx < 0) return 0;         // No elements left
        if (dp[idx][cur] != -1) return dp[idx][cur];

        int noTake = Rec(idx - 1, cur, arr, dp);

        int take = 0;
        if (cur >= arr[idx])
        {
            take = Rec(idx - 1, cur - arr[idx], arr, dp);
        }

        dp[idx][cur] = (take == 1 || noTake == 1) ? 1 : 0;
        return dp[idx][cur];
    }

    public bool IsSubsetSum(int[] arr, int target)
    {
        int m = arr.Length;

        // Create 2D dp array initialized with -1
        int[][] dp = new int[m][];
        for (int i = 0; i < m; i++)
        {
            dp[i] = Enumerable.Repeat(-1, target + 1).ToArray();
        }

        return Rec(m - 1, target, arr, dp) == 1;
    }
}