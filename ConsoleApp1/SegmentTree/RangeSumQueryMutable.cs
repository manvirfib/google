public class NumArray {
    int[] seg;
    int[] nums;
    int n;
    public NumArray(int[] nums) {
        n = nums.Length;
        this.nums = nums;
        seg = new int[4*n];
        BuildSegment(0, 0, n - 1);
    }

    int BuildSegment(int idx, int start, int end){
        if(start == end){
            seg[idx] = nums[start];
            return seg[idx];
        }
        int mid = start + (end - start)/2;

        int left = BuildSegment(2*idx + 1, start, mid);
        int right = BuildSegment(2*idx + 2, mid + 1, end);

        seg[idx] = left + right;
        return seg[idx];
    }

    void PointUpdate(int idx, int start, int end, int i, int val){
        int mid = start + (end - start)/2;
        if(start == end){
            nums[i] = val;
            seg[idx] = val;
            return;
        }
        if(i <= mid){
            PointUpdate(2*idx + 1, start, mid, i, val);
        }
        else{
            PointUpdate(2*idx + 2, mid + 1, end, i, val);
        }
        seg[idx] = seg[2*idx + 1] + seg[2*idx + 2];
    }
    
    public void Update(int index, int val) {
        PointUpdate(0, 0, n - 1, index, val);
    }

    int Query(int idx, int start, int end, int left, int right){
        if(right < start || left > end){
            return 0;
        }
        if(left <= start && right >= end){
            return seg[idx];
        }
        int mid = start + (end - start)/2;

        return Query(2*idx + 1, start, mid, left, right) + Query(2*idx + 2, mid + 1, end, left, right);
    }
    
    public int SumRange(int left, int right) {
        return Query(0, 0, n - 1, left, right);
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(index,val);
 * int param_2 = obj.SumRange(left,right);
 */