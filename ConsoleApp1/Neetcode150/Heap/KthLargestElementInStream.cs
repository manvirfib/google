public class KthLargest {
    int k;
    PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
    public KthLargest(int k, int[] nums) {
        this.k = k;
        foreach(var num in nums){
            minHeap.Enqueue(num, num);
            if(minHeap.Count > k){
                minHeap.Dequeue();
            }
        }
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val, val);
        if(minHeap.Count > k)
        minHeap.Dequeue();
        minHeap.TryPeek(out int smallest, out _);

        return smallest;
    }
}