public class LastStoneWeightProblem {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y)=>y.CompareTo(x)));

        foreach(var stone in stones){
            pq.Enqueue(stone, stone);
        }

        int result = 0;

        while(pq.Count > 1){
            var first = pq.Dequeue();
            var second = pq.Dequeue();
            int diff = Math.Abs(first - second);
            if(diff > 0){
                pq.Enqueue(diff, diff);
            }
        }

        if(pq.Count != 0){
            result = pq.Dequeue();
        }

        return result;
    }
}
