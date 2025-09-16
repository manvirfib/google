public class SubsetsProblem {
    void dfs(int idx, List<int> ds, List<List<int>> result, int[] nums){
        if(idx == nums.Length){
            result.Add(new List<int>(ds));
            return;
        }
        ds.Add(nums[idx]);
        dfs(idx + 1, ds, result, nums);
        ds.RemoveAt(ds.Count - 1);
        dfs(idx + 1, ds, result, nums);
    }
    public List<List<int>> Subsets(int[] nums) {
        var result = new List<List<int>>();

        dfs(0, new List<int>(), result, nums);

        return result;
    }
}
