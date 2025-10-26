public class FindCheapestPriceSolution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        Queue<(int v, int steps, int price)> queue = new();

        List<(int, int)>[] adj = new List<(int, int)>[n];

        for (int i = 0; i < n; i++)
            adj[i] = new List<(int, int)>();

        foreach (var f in flights)
            adj[f[0]].Add((f[1], f[2]));


        int[] prices = new int[n];
        Array.Fill(prices, int.MaxValue);
        prices[src] = 0;

        queue.Enqueue((src, 0, 0));

        while(queue.Count > 0){
            var (v, steps, price) = queue.Dequeue();
            var list = adj[v];
            if(steps > k) continue;
            foreach(var (node, p) in list){
                if((price + p) < prices[node]){
                    prices[node] = p + price;
                    queue.Enqueue((node, steps + 1, p + price));
                }
            }
        }

        return prices[dst] == int.MaxValue ? -1 : prices[dst];
    }
}