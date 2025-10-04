public class WordLadder {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        Queue<(string word, int level)> queue = new();
        HashSet<string> hSet = new HashSet<string>(wordList);
        if(!hSet.Contains(endWord))
            return 0;

        queue.Enqueue((beginWord, 1));

        while(queue.Count > 0){
            var (word, level) = queue.Dequeue();

            if(word == endWord)
                return level;

            var charString = word.ToCharArray();
            
            for(int i = 0; i < word.Length; i++){
                char ori = charString[i];
                for(char j = 'a'; j <= 'z'; j++){
                    if(j == ori) continue;
                    charString[i] = j;
                    var newWord = new string(charString);
                    if(hSet.Contains(newWord)){
                        queue.Enqueue((newWord, level + 1));
                        hSet.Remove(newWord);
                    }
                }
                charString[i] = ori;
            }
        }

        return 0;
    }
}
