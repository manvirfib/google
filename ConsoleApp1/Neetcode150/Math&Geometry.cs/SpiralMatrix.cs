public class SpiralOrderSolution {
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int> res = new();
        int top = 0, l = 0;
        int bottom = matrix.Length - 1, r = matrix[0].Length - 1;

        while(l <= r && top <= bottom){
            for(int i = l; i <= r; i++){
                res.Add(matrix[top][i]);
            }
            top++;

            for(int i = top; i <= bottom; i++){
                res.Add(matrix[i][r]);
            }
            r--;

            if(top <= bottom)
            for(int i = r; i >= l; i--){
                res.Add(matrix[bottom][i]);
            }
            bottom--;

            if(l <= r)
            for(int i = bottom; i >= top; i--){
                res.Add(matrix[i][l]);
            }
            l++;
        }

        return res;
    }
}