public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        var lower = SearchLowerBound(nums, target);
        if(lower == nums.Length || nums[lower] != target)   return new int[]{ -1, -1 };
        else return new int[]{ lower, SearchUpperBound(nums, target) - 1};
    }
    public int SearchUpperBound(int[] nums, int target) {
        int arrayLength = nums.Length;
        int low = 0, high = arrayLength - 1;
        int mid = 0;

        while (low <= high)
        {
            mid = low + (high - low) / 2;
            if (nums[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return low;
    }
    public int SearchLowerBound(int[] nums, int target) {
        int arrayLength = nums.Length;
        int low = 0, high = arrayLength - 1;
        int mid = 0;

        while (low <= high)
        {
            mid = low + (high - low) / 2;
            if (nums[mid] >= target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return low;
    }
}