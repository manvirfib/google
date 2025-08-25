public class ProductExceptSelfSolution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] temp1 = new int[nums.Length];
        int[] temp2 = new int[nums.Length];
        int[] result = new int[nums.Length];

        int product = 1;
        for(int i = 0; i < nums.Length; i++){
            temp1[i] = product;
            product *= nums[i];
        }

        product = 1;
        for(int i = nums.Length - 1; i >= 0; i--){
            temp2[i] = product;
            product *= nums[i];
        }

        for(int i = 0; i < nums.Length; i++){
            result[i] = temp1[i] * temp2[i];
        }

        return result;
    }
}
