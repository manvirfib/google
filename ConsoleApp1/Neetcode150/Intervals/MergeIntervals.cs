public class MergeSolution {
    public int[][] Merge(int[][] inv) {
        int n = inv.Length;
        List<int[]> res = new();
        Array.Sort(inv, (a, b) => a[0].CompareTo(b[0]));

        int i = 0;
        while(i < n){
            int start = i;
            int max = inv[start][1];
            while(i < n - 1 && max >= inv[i + 1][0]){
                max = Math.Max(max, inv[i + 1][1]);
                i++;
            }
            res.Add(new int[] { inv[start][0], max });
            i++;
        }

        return res.ToArray();
    }
}
