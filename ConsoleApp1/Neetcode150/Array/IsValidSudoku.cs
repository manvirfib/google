public class ValidSudoku {
    public bool IsValidSudoku(char[][] board) {
        bool result = true;
        for(int i = 0; i < 9; i++){
        HashSet<char> hs = new HashSet<char>();
        HashSet<char> hs1 = new HashSet<char>();
            for(int j = 0; j < 9; j++){
                if(board[i][j] != '.'){
                    if(hs.Contains(board[i][j]))
                    return false;
                    hs.Add(board[i][j]);
                }
            }
        }

        for(int i = 0; i < 9; i++){
        HashSet<char> hs = new HashSet<char>();
            for(int j = 0; j < 9; j++){
                if(board[j][i] != '.'){
                    if(hs.Contains(board[j][i]))
                    return false;
                    hs.Add(board[j][i]);
                }
            }
        }

        for(int i = 0; i < 9;){
            for(int j = 0; j < 9;){
                result = result & CheckSudo(i, j, board);
                j = j+3;
            }
            i = i+3;
        }

        return result;
    }

    public bool CheckSudo(int a, int b, char[][] board){
        HashSet<char> hs = new HashSet<char>();
        for(int i = a; i < a+3; i++){
            for(int j = b; j < b+3; j++){
                if(board[i][j] != '.'){
                    if(hs.Contains(board[i][j]))
                    return false;
                    hs.Add(board[i][j]);
                }
            }
        }

        return true;
    }
}