public class InsertSolution {
    public int[][] Insert(int[][] inv, int[] newInv) {
        List<int[]> res = new();
        int n = inv.Length;

        //before
        int i = 0;
        while(i < n && newInv[0] > inv[i][1]){
            res.Add(new int[]{ inv[i][0], inv[i][1] });
            i++;
        }

        //processing
        int max = newInv[1];
        int min = newInv[0];
        while(i < n && newInv[1] >= inv[i][0]){
            max = Math.Max(max, inv[i][1]);
            min = Math.Min(min, inv[i][0]);
            i++;
        }
        res.Add(new int[] { min, max });

        if(i == n) return res.ToArray();

        //after
        while(i < n){
            res.Add(new int[]{ inv[i][0], inv[i][1] });
            i++;
        }

        return res.ToArray();
    }
}
