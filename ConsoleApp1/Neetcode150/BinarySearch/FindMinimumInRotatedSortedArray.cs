public class FindMinSolution {
    public int FindMin(int[] nums) {
        int i = 0, j = nums.Length - 1;
        
        while(i < j){
            int mid = i + (j - i)/2; //Overflow condition
            if(nums[mid] > nums[j]){
                i = mid + 1;
            }
            else{
                j = mid;
            }
        }

        return nums[i];
    }
}