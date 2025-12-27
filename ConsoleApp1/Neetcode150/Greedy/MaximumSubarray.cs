public class MaxSubArray1Solution {
    public int MaxSubArray(int[] nums) {
        int i = 1;
        int max = nums[0];
        int n = nums.Length;
        int temp = nums[0] < 0 ? 0 : nums[0];

        while(i < n){
            temp = temp + nums[i];
            max = Math.Max(temp, max);
            
            if(temp < 0) temp = 0;
            i++;
        }

        return max;
    }
}
//Kadanes algorithm
