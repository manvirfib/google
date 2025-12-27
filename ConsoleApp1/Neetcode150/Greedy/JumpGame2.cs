public class JumpGame2Solution {
    public int Jump(int[] nums) {
        int n = nums.Length;
        int l = 0, r = 0, i = 0;
        int count = 0;
        while(i < n){
            int max = 0;
            while(l < n && l <= r){
                max = Math.Max(l + nums[l], max);
                l++;
            }
            count++;
            l = r + 1;
            r = max;
            i = l;
        }
        return count - 1;
    }
}
