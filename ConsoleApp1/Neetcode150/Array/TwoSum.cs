public class Sum {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict1 = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            if(dict1.ContainsKey(nums[i])){
                return new int[]{dict1[nums[i]], i};
            }
            else{
                dict1[target-nums[i]] = i;
            }
        }

        return new int[]{0, 0};
    }
}