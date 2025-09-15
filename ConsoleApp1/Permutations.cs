public class Permutation {
    void dfs(int[] nums, bool[] selected, List<int> ds, IList<IList<int>> result){
        if(ds.Count == nums.Length){
            result.Add(new List<int>(ds));
            return;
        }
        for(int i = 0; i < nums.Length; i++){
            if(!selected[i]){
                selected[i] = true;
                ds.Add(nums[i]);
                dfs(nums, selected, ds, result);
                ds.RemoveAt(ds.Count - 1);
                selected[i] = false;
            }
        }
    }
    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        var selected = new bool[nums.Length];
        dfs(nums, selected, new List<int>(), result);

        return result;
    }
}