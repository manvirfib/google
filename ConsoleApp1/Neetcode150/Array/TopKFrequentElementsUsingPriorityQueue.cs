public class PriorityQueueTopKFrequent {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach(var num in nums){
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach(var ele in dict){
            pq.Enqueue(ele.Key, -ele.Value);
        }

        int[] result = new int[k];

        for(int i = 0; i < k; i++){
            result[i] = pq.Dequeue();
        }

        return result;
    }
}
