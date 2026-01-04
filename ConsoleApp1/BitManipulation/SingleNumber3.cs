public class SingleNumberSolution {
    public int[] SingleNumber(int[] nums) {
        int sum = 0;
        foreach(var num in nums){
            sum = sum ^ num;
        }
        int one = 0, two = 0;
        int rightMostBit = (sum & (sum - 1)) ^ sum;
        for(int i = 0; i < nums.Length; i++){
            if((nums[i] & rightMostBit) != 0){
                one ^= nums[i];
            }
            else{
                two ^= nums[i];
            }
        }
        return new int[] { one, two };
    }
}