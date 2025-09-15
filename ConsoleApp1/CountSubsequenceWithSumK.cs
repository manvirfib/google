
class Subsequence
{
    int target;
    public int GetNumber(int[] arr, int target)
    {
        this.target = target;
        dfs(0, arr, 0);

        return dfs(0, arr, 0);
    }
    int dfs(int idx, int[] nums, int sum)
    {
        if (idx >= nums.Length)
        {
            if (sum == target)
            {
                return 1;
            }
            return 0;
        }
        sum += nums[idx];
        int left = dfs(idx + 1, nums, sum);
        sum -= nums[idx];
        int right = dfs(idx + 1, nums, sum);
        return left + right;
    }
}