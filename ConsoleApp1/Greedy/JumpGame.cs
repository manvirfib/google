public class CanJumpSolution {
    public bool CanJump(int[] nums) {
        int maxIndex = 0;
        int n = nums.Length;
        for(int i = 0; i < n; i++){
            if(nums[i] == 0 && maxIndex <= i && i != (n - 1)) return false;
            maxIndex = Math.Max(maxIndex, i + nums[i]);
        }
        return true;
    }
}