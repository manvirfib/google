public class WordSearch {
    // Right Down Left Up
    bool dfs(int i, int j, char[][] board, string word, int cur, bool[][] selected){
        if(cur == word.Length){
            return true;
        }
        if(!selected[i][j] && board[i][j] == word[cur]){
            selected[i][j] = true;
            if(j < (board[0].Length - 1)){
                if(dfs(i, j + 1, board, word, cur + 1, selected))
                    return true;
            } 
            if(i < (board.Length - 1)){
                if(dfs(i + 1, j, board, word, cur + 1, selected))
                    return true;
            } 
            if(j > 0){
                if(dfs(i, j - 1, board, word, cur + 1, selected))
                    return true;
            } 
            if(i > 0){
                if(dfs(i - 1, j, board, word, cur + 1, selected) == true)
                    return true;
            } 
            selected[i][j] = false;
            if((cur + 1) == word.Length)
            return true;
        }
        return false;
    }
    public bool Exist(char[][] board, string word) {
        if(word == null || word == ""){
            return true;
        }
        bool[][] selected = new bool[board.Length][];

        for(int i = 0; i < board.Length; i++){
            selected[i] = new bool[board[i].Length];
        }

        int cur = 0;

        for(int i = 0; i < board.Length; i++){
            for(int j = 0; j < board[0].Length; j++){
                if(dfs(i, j, board, word, cur, selected))
                    return true;
            }
        }

        return false;
    }
}
