public class SearchInRotatedArray2 {
    public bool Search(int[] nums, int target) {
        int n = nums.Length;
        int low = 0, high = n - 1;

        while(low <= high){
            int mid = low + (high - low)/2;
            if(nums[mid] == target){
                return true;
            }
            //Only difference-shrinking
            if (nums[low] == nums[mid] && nums[mid] == nums[high])
            {
                low++;
                high--;
                continue;
            }
            //
            if (nums[mid] <= nums[high])
            {
                if (target <= nums[high] && target >= nums[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            else
            {
                if (target >= nums[low] && target <= nums[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
        }

        return false;
    }
}
