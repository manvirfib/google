public class MinIntervalSolution {
    public int[] MinInterval(int[][] inv, int[] queries) {
        int n = inv.Length;
        int m = queries.Length;

        PriorityQueue<(int start, int end), int> pq = new();

        Dictionary<int, int> dict = new();
        int[] que = queries.OrderBy(p => p).ToArray();
        Array.Sort(inv, (a, b) => a[0].CompareTo(b[0]));
        int i = 0;

        foreach(var q in que){
            while(i < n && inv[i][0] <= q){
                int r = inv[i][1], l = inv[i][0];
                pq.Enqueue((r - l + 1, r), r - l + 1);
                i++;
            }

            while(pq.Count > 0 && pq.Peek().end < q){
                pq.Dequeue();
            }

            dict[q] = pq.Count == 0 ? -1 : pq.Peek().start;
        }

        int[] result = new int[m];

        for(int j = 0; j < m; j++){
            result[j] = dict[queries[j]];
        }

        return result;
    }
}