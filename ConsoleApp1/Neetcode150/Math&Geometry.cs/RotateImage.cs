public class RotateSolution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        int l = 0, r = n - 1;
        while(l < r){
            int len = r - l;
            int i = 0;
            while(i < len){
                int top = l, bottom = r;
                int topLeft = matrix[top][l + i];
                matrix[top][l + i] = matrix[bottom - i][l];
                matrix[bottom - i][l] = matrix[bottom][r - i];
                matrix[bottom][r - i] = matrix[top + i][r];
                matrix[top + i][r] = topLeft;
                i++;
            }
            r--;
            l++;
        }
    }
}