public class Subsets2 {
    void dfs(int idx, List<int> ds, List<List<int>> result, int[] nums){
        result.Add(new List<int>(ds));
        for(int i = idx; i < nums.Length; i++){
            if(i > idx && nums[i] == nums[i - 1]) continue;
            ds.Add(nums[i]);
            dfs(i + 1, ds, result, nums);
            ds.RemoveAt(ds.Count - 1);
        }
    }
    public List<List<int>> SubsetsWithDup(int[] nums) {
        var result = new List<List<int>>();
        Array.Sort(nums);
        dfs(0, new List<int>(), result, nums);

        return result;
    }
}

