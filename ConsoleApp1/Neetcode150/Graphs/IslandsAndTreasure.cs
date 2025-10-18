public class IslandsAndTreasureSolution {
    public void islandsAndTreasure(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;

        Queue<(int, int)> queue = new Queue<(int, int)>();

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 0){
                    queue.Enqueue((i, j));
                }
            }
        }

        int count = 1;
        int[] dirX = { 1, 0, -1, 0 };
        int[] dirY = { 0, 1, 0, -1 };

        while(queue.Count > 0){
            int size = queue.Count;
            for(int i = 0; i < size; i++){
                var (a, b) = queue.Dequeue();
                for(int j = 0; j < 4; j++){
                    int x = a + dirX[j];
                    int y = b + dirY[j];
                    if(x >= 0 && y >= 0 && x < m && y < n && grid[x][y] == int.MaxValue){
                        grid[x][y] = count;
                        queue.Enqueue((x, y));
                    }
                }
            }
            count++;
        }
    }
}
