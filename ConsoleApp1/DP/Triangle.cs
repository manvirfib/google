public class Triangle {
    public int MinimumTotal(IList<IList<int>> tri) {
        int m = tri.Count;

        for(int i = m - 2; i >= 0; i--){
            int n = tri[i].Count;
            for(int j = 0; j < n; j++){
                int l1 = tri[i + 1][j] + tri[i][j], l2 = tri[i + 1][j + 1] + tri[i][j];
               
                tri[i][j] = Math.Min(l1, l2);
            }
        }

        return tri[0][0];
    }
}