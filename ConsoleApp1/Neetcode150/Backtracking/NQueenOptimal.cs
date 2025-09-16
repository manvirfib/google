public class SolveNQueensOptimal {
    int n;
    void Place(int row, List<char[]> board, List<List<string>> result, bool[] rowCheck, bool[] lowerD, bool[] upperD){
        if(row == n){
            result.Add(board.Select(r => new string(r)).ToList());
            return;
        }
        for(int col = 0; col < n; col++){
            if(rowCheck[col] == false && lowerD[row + col] == false && upperD[n - 1 + col - row] == false){
                board[row][col] = 'Q';
                rowCheck[col] = true;
                lowerD[row + col] = true;
                upperD[n - 1 + col - row] = true;
                Place(row + 1, board, result, rowCheck, lowerD, upperD);
                board[row][col] = '.';
                rowCheck[col] = false;
                lowerD[row + col] = false;
                upperD[n - 1 + col - row] = false;
            }
        }
    }
    public List<List<string>> SolveNQueens(int n) {
        var result = new List<List<string>>();
        var board = new List<char[]>();
        for(int i = 0; i < n; i++){
            board.Add(new string('.', n).ToCharArray());
        }
        this.n = n;

        bool[] rowCheck = new bool[n + 1], lowerDiagonal = new bool[2 * n + 1], upperDiagonal = new bool[2 * n + 1];

        Place(0, board, result, rowCheck, lowerDiagonal, upperDiagonal);

        return result;
    }
}
