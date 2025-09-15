public class KthLargestInArray {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        foreach(var num in nums){
            pq.Enqueue(num, num);
            if(pq.Count > k)
            pq.Dequeue();
        }

        return pq.Dequeue();
    }
}
