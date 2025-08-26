public class ThreeSumSolution {
    public List<List<int>> ThreeSum(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<List<int>> result = new List<List<int>>();
        Array.Sort(nums);

        for(int i = 0; i < nums.Length-2; i++){
            int j = i + 1;
            int k = nums.Length - 1;
            while(j < k){
                int sum = nums[i] + nums[j] + nums[k];

                if(sum == 0){
                    if(dict.ContainsKey(nums[j]) && dict[nums[j]] == nums[k]){
                        j++;
                        k--;
                        continue;
                    }
                    else{
                        dict[nums[j]] = nums[k];
                        result.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        j++;
                        k--;
                    }
                }
                else if(sum > 0){
                    k--;
                }
                else{
                    j++;
                }
            }
        }
        return result;
    }
}
