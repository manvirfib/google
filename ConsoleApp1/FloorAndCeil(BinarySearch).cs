class FloorAndCeil
{
    public (int, int) GetData(int[] arr, int target)
    {
        int len = arr.Length;
        int low = 0, high = len - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target)
            {
                return (mid, mid);
            }
            else if (arr[mid] >= target)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return (low - 1, low);
    }
}