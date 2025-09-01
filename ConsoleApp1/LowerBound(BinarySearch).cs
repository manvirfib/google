public class LowerBound {
    public int SearchInsert(int[] nums, int target) {
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