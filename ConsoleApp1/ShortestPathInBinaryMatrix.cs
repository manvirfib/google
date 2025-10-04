public class ShortestPathBinaryMatrixSolution {
    int[] dirX = { -1, -1, -1, 0, 0, 1, 1, 1 };
    int[] dirY = { -1, 0, 1, -1, 1, -1, 0, 1 };

    public int ShortestPathBinaryMatrix(int[][] grid) {
         int n = grid.Length;
        if(grid[0][0] == 1 || grid[n - 1][n - 1] == 1) return -1;
         Queue<(int, int)> queue = new();

         if(n == 1 && grid[0][0] == 0) return 1;

         queue.Enqueue((0, 0));
         grid[0][0] = 1;

         while(queue.Count > 0){
            var (minNodeX, minNodeY) = queue.Dequeue();
            for(int i = 0; i < 8; i++){
                int x = minNodeX + dirX[i];
                int y = minNodeY + dirY[i];
                if(x >= 0 && y >= 0 && x < n && y < n && grid[x][y] == 0){
                    grid[x][y] = grid[minNodeX][minNodeY] + 1;
                    if(x == (n - 1) && y == (n - 1)) return grid[x][y];

                    queue.Enqueue((x, y));
                }
            }
         }

         return -1;
    }
}