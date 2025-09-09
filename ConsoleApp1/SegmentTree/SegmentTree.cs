class SegmentTree2
{
    int[] nums;
    int[] segment;
    public SegmentTree2(int[] nums)
    {
        this.nums = nums;
        segment = new int[4 * nums.Length];
        Console.WriteLine(Build(0, 0, nums.Length - 1));
    }
    public int Build(int idx, int low, int high)
    {
        if (low == high)
        {
            segment[idx] = nums[low];
            return nums[low];
        }

        int left = 2 * idx + 1;
        int right = 2 * idx + 2;

        int mid = (low + high) / 2;

        int BuildL = Build(left, low, mid);
        int BuildR = Build(right, mid + 1, high);

        segment[idx] = Math.Max(BuildL, BuildR);

        return segment[idx];
    }

    public int MaxBetween(int l, int r)
    {
        return Query(0, l, r, 0, nums.Length - 1);
    }

    int Query(int idx, int l, int r, int low, int high)
    {
        if (l <= low && high <= r)
        {
            return segment[idx];
        }
        if (low > r || high < l)
        {
            return int.MinValue;
        }
        int mid = (low + high) / 2;
        int buildL = Query(2 * idx + 1, l, r, low, mid);
        int buildR = Query(2 * idx + 2, l, r, mid + 1, high);

        return Math.Max(buildL, buildR);
    }
}