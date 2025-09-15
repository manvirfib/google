class CombinationSum
{
    List<List<int>> result;

    void dfs(int idx, int[] nums, int target, List<int> ds)
    {
        if (idx == nums.Length)
        {
            if (target == 0)
            {
                result.Add(new List<int>(ds));
                return;
            }
            return;
        }

        if (nums[idx] <= target)
        {
            ds.Add(nums[idx]);
            dfs(idx, nums, target - nums[idx], ds);
            ds.RemoveAt(ds.Count - 1);
        }
        dfs(idx, nums, target, ds);
    }

    public List<List<int>> GetSum(int[] arr, int target)
    {
        result = new List<List<int>>();
        dfs(0, arr, target, new List<int>());
        return result;
    }
}
