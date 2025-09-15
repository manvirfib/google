public class KClosestPointsToOrigin {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<(int, int), int> queue = new PriorityQueue<(int, int), int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

        for(int i = 0; i < points.Length; i++){
            queue.Enqueue((points[i][0], points[i][1]), points[i][0]*points[i][0] + points[i][1]*points[i][1]);
            if(queue.Count > k)
            queue.Dequeue();
        }

        int[][] result = new int[k][];
        for(int i = 0; i < k; i ++){
            result[i] = new int[2];
            var item = queue.Dequeue();
            result[i][0] = item.Item1;
            result[i][1] = item.Item2;
        }

        return result;
    }
}
