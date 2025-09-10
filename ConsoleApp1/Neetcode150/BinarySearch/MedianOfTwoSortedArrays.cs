public class MedianSortedArrays {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if(nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);

        int n1 = nums1.Length, n2 = nums2.Length;
        int low = 0, high = n1;
        int n = n1 + n2;
        int left = (n1 + n2 + 1)/2;

        while(low <= high){
            int mid1 = low + (high - low)/2;
            int mid2 = left - mid1;
            int l1 = int.MinValue;
            int l2 = int.MinValue;
            int r1 = int.MaxValue;
            int r2 = int.MaxValue;
            if((mid1-1) >= 0) l1 = nums1[mid1 - 1];
            if((mid2-1) >= 0) l2 = nums2[mid2 - 1];
            if(mid1 < n1) r1 = nums1[mid1];
            if(mid2 < n2) r2 = nums2[mid2];
            if(l1 <= r2 && l2 <= r1){
                if(n%2 == 1) return Math.Max(l1, l2);
                return (double)((double)Math.Max(l1, l2) + Math.Min(r1, r2))/2.0;
            }
            else if(l1 > r2){
                high = mid1 - 1;
            }
            else{
                low = mid1 + 1;
            }
        }

        return 0;
    }
}
