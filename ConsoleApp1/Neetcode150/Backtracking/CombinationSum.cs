public class CombinationSumProblem {
    void dfs(int idx, int[] nums, int target, List<List<int>> result, List<int> ds){
        if(idx == nums.Length){
            if(target == 0){
                result.Add(new List<int>(ds));
            }
            return;
        }
        if(idx <= target){
            ds.Add(nums[idx]);
            dfs(idx, nums, target - nums[idx], result, ds);
            ds.RemoveAt(ds.Count - 1);
        }
        dfs(idx + 1, nums, target, result, ds);
    }
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var result = new List<List<int>>();

        dfs(0, nums, target, result, new List<int>());

        return result;
    }
}
