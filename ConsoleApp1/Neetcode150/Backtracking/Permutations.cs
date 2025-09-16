public class Permutations {
    void dfs(List<List<int>> result, List<int> ds, int[] nums, bool[] selected){
        if(ds.Count == nums.Length){
            result.Add(new List<int>(ds));
        }
        for(int i = 0; i < nums.Length; i++){
            if(!selected[i]){
                selected[i] = true;
                ds.Add(nums[i]);
                dfs(result, ds, nums, selected);
                ds.RemoveAt(ds.Count - 1);
                selected[i] = false;
            }
        }


    }
    public List<List<int>> Permute(int[] nums) {
        var result = new List<List<int>>();
        bool[] selected = new bool[nums.Length];
        dfs(result, new List<int>(), nums, selected);

        return result;
    }
}
