public class SetZeroesSolution {
    public void SetZeroes(int[][] matrix) {
        Queue<(int x, int y)> queue = new();
        int m = matrix.Length;
        int n = matrix[0].Length;

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(matrix[i][j] == 0){
                    queue.Enqueue((i, j));
                }
            }
        }

        while(queue.Count > 0){
            // process column
            var id = queue.Dequeue();
            for(int i = 0; i < m; i++){
                matrix[i][id.y] = 0;
            }
            // process row
            for(int i = 0; i < n; i++){
                matrix[id.x][i] = 0;
            }
        }

    }
}