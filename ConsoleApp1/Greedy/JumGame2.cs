public class JumpGameSolution {
    public int Jump(int[] nums) {
        int n = nums.Length;
        int l = 0, r = 0;
        int count = 0;
        while(r < n - 1){
            int farthest = 0;
            while(l <= r){
                farthest = Math.Max(farthest, l + nums[l]);
                l++;;
            }
            r = farthest;
            count++;
        }
        return count;
    }
}