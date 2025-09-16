public class CombinationSum2Problem {
    void dfs(int idx, int[] nums, int target, List<List<int>> result, List<int> ds){
        if(target == 0){
            result.Add(new List<int>(ds));
            return;
        }
        for(int i = idx; i < nums.Length; i++){
            if(i > idx && nums[i] == nums[i - 1]){
                continue;
            }
            ds.Add(nums[i]);
            dfs(i + 1, nums, target - nums[i], result, ds);
            ds.RemoveAt(ds.Count - 1);
        }
    }
    public List<List<int>> CombinationSum2(int[] cand, int target) {
        Array.Sort(cand);

        var result = new List<List<int>>();

        dfs(0, cand, target, result, new List<int>());

        return result;
    }
}
