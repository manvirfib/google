public class SearchMatrixSolution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        int i = 0, j = m * n - 1;
        while(i <= j){
            int mid = (i+j)/2;
            if(target < matrix[mid/n][mid%n]){
                j = mid - 1;
            }
            else if(target > matrix[mid/n][mid%n]){
                i = mid + 1;
            }
            else{
                return true;
            }
        }

        return false;
    }
}
