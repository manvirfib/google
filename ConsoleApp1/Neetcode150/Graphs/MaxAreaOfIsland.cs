public class MaxAreaOfIslandSolution {
    int[] dirX = { 0, 1, -1, 0 };
    int[] dirY = { 1, 0, 0, -1 };
    int m = 0, n = 0;
    public int MaxAreaOfIsland(int[][] grid) {
        m = grid.Length;
        n = grid[0].Length;
        int res = 0;
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 1){
                   res = Math.Max(res, dfs(i, j, grid));
                }
            }
        }

        return res;
    }
    int dfs(int r, int c, int[][] grid){
        grid[r][c] = 0;
        int area = 1;
        for(int i = 0; i < 4; i++){
            int x = r + dirX[i];
            int y = c + dirY[i];
            if(x >= 0 && y >= 0 && x < m && y < n && grid[x][y] == 1){
                area += dfs(x, y, grid);
            }
        }

        return area;
    }
}
