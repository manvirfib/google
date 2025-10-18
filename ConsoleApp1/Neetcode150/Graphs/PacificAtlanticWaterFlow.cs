public class PacificAtlanticSolution {
    int m = 0, n = 0;
    int[] dirx = { 1, 0, -1, 0 };
    int[] diry = { 0, 1, 0, -1 };

    void dfs(int r, int c, bool[,] v, int[][] ht){
        v[r, c] = true;
        for(int i = 0; i < 4; i++){
            int x = r + dirx[i];
            int y = c + diry[i];
            if(x >= 0 && y >= 0 && x < m && y < n && ht[x][y] >= ht[r][c] && !v[x, y]){
                dfs(x, y, v, ht);
            }
        }
    }
    public IList<IList<int>> PacificAtlantic(int[][] ht) {
        m = ht.Length;
        n = ht[0].Length;
        bool[,] p = new bool[m, n];
        bool[,] a = new bool[m, n]; 

        for(int i = 0; i < m; i++){
            dfs(i, 0, p, ht);
            dfs(i, n - 1, a, ht);
        }

        for(int i = 0; i < n; i++){
            dfs(0, i, p, ht);
            dfs(m - 1, i, a, ht);
        }

        List<IList<int>> result = new();

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(p[i, j] && a[i, j]){
                    result.Add(new int[] { i, j });
                }
            }
        }

        return result;
    }
}
