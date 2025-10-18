public class RegionSolution {
    int[] dirx = { 1, 0, -1, 0 };
    int[] diry = { 0, 1, 0, -1 };
    public void Solve(char[][] board) {
        int m = board.Length;
        int n = board[0].Length;
        bool[,] visited = new bool[m, n];

        Queue<(int, int)> queue = new();

        for(int i = 0; i < m; i++){
            if(board[i][0] == 'O')
                queue.Enqueue((i, 0));
            if(board[i][n - 1] == 'O')
                queue.Enqueue((i, n - 1));
        }

        for(int i = 0; i < n; i++){
            if(board[0][i] == 'O')
                queue.Enqueue((0, i));
            if(board[m - 1][i] == 'O')
                queue.Enqueue((m - 1, i));
        }

        while(queue.Count > 0){
            var (r, c) = queue.Dequeue();
            visited[r, c] = true;
            for(int i = 0; i < 4; i++){
                int x = r + dirx[i];
                int y = c + diry[i];
                if(x >= 0 && y >= 0 && x < m && y < n && board[x][y] == 'O' && !visited[x, y]){
                    queue.Enqueue((x, y));
                }
            }
        }

        for(int i = 1; i < (m - 1); i++){
            for(int j = 1; j < (n - 1); j++){
                if(!visited[i, j] && board[i][j] == 'O'){
                    board[i][j] = 'X';
                }
            }
        }
    }
}
