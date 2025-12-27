public class CanJump1Solution {
    public bool CanJump(int[] nums) {
        int maxIdx = 0;
        int n = nums.Length;
        for(int i = 0; i < n; i++){
            maxIdx = Math.Max(i + nums[i], maxIdx);
            if(maxIdx == n - 1) return true;
            if(nums[i] == 0 && maxIdx <= i) return false;
        }
        return true;
    }
}
