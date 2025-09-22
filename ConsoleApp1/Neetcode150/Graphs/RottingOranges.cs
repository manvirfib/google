public class OrangesRottingProblem {
    int m, n;
    int[] dirX = new int[]{ 1, 0, -1, 0};
    int[] dirY = new int[]{ 0, 1, 0, -1};

    public int OrangesRotting(int[][] grid) {
        m = grid.Length;
        n = grid[0].Length;
        int max = int.MinValue;
        Queue<int[]> queue = new Queue<int[]>();
        int totalFresh = 0;
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 2){
                    queue.Enqueue(new int[]{ i, j });
                }
                if(grid[i][j] == 1){
                    totalFresh++;
                }
            }
        }

        if(totalFresh == 0)
        return 0;
        int time = 0;
        while(queue.Count > 0){
            time++;
            int size = queue.Count;
            for(int i = 0; i < size; i++){
                var rotten = queue.Dequeue();
                for(int j = 0; j < 4; j++){
                    int x = rotten[0] + dirX[j];
                    int y = rotten[1] + dirY[j];
                    if(x >= 0 && y >= 0 && x < m && y < n && grid[x][y] == 1){
                        grid[x][y] = 2;
                        totalFresh--;
                        queue.Enqueue(new int[]{ x, y });
                    }
                }
            }
        }

        if(totalFresh != 0)
        return -1;

        return time - 1;
    }
}