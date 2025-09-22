public class NumIslandsProblem {
    int m, n;
    int[][] dirs = {
        new int[]{ 1, 0 },
        new int[]{ 0, 1 },
        new int[]{ 0, -1 },
        new int[]{ -1, 0 }
    };
    public int NumIslands(char[][] grid) {
        m = grid.Length;
        n = grid[0].Length;
        int count = 0;
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == '1'){
                    count++;
                    dfs(i, j, grid);
                }
            }
        }

        return count;
    }
    void dfs(int i, int j, char[][] grid){
        grid[i][j] = '0';
        for(int k = 0; k < 4; k++){
            int x = i + dirs[k][0];
            int y = j + dirs[k][1];
            if(x >= 0 && y >= 0 && x < m && y < n && grid[x][y] == '1')
            dfs(x, y, grid);
        }
    }
}