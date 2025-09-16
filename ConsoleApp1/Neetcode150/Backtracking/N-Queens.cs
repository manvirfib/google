public class SolveNQueensProblem {
    int n;
    void Place(int row, List<char[]> board, List<List<string>> result){
        if(row == n){
            result.Add(board.Select(r => new string(r)).ToList());
            return;
        }
        for(int col = 0; col < n; col++){
            if(IsSafe(row, col, board)){
                board[row][col] = 'Q';
                Place(row + 1, board, result);
                board[row][col] = '.';
            }
        }
    }
    bool IsSafe(int row, int col, List<char[]> board){
        int prow = row;
        int pcol = col;

        // Checking Same Column
        while(row >= 0){
            if(board[row][col] == 'Q')
                return false;
            row--;
        }

        row = prow;
        col = pcol;

        // Checking Diagonal
        while(row >= 0 && col >= 0){
            if(board[row][col] == 'Q')
                return false;
            row--;
            col--;
        }

        row = prow;
        col = pcol;
        // Checking Diagonal
        while(row >= 0 && col < n){
            if(board[row][col] == 'Q')
                return false;
            row--;
            col++;
        }

        return true;
    }
    public List<List<string>> SolveNQueens(int n) {
        var result = new List<List<string>>();
        var board = new List<char[]>();
        for(int i = 0; i < n; i++){
            board.Add(new string('.', n).ToCharArray());
        }
        this.n = n;

        Place(0, board, result);

        return result;
    }
}
