public class MissingNumberSolution {
    public int MissingNumber(int[] nums) {
        int xor = 0;
        int n = nums.Length;
        for(int i = 0; i < n; i++){
            xor ^= i;
            xor ^= nums[i];
        }
        return xor ^ n;
    }
}
