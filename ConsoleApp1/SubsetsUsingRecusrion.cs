class Recursion
{
    int target;
    bool dfs(int idx, int[] nums, int sum, List<int> ds)
    {
        if (idx >= nums.Length)
        {
            if (sum == target)
            {
                foreach (var i in ds)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
                return true;
            }
            return false;
        }
        sum += nums[idx];
        ds.Add(nums[idx]);
        if (dfs(idx + 1, nums, sum, ds))
        {
            return true;
        }
        sum -= nums[idx];
        ds.RemoveAt(ds.Count - 1);
        if (dfs(idx + 1, nums, sum, ds))
        {
            return true;
        }
        return false;
    }
    public void Test()
    {
        int[] arr = { 1, 4, 2, 6, 8, 9};
        int target = 8;
        this.target = target;
        dfs(0, arr, 0, new List<int>());
    }
}