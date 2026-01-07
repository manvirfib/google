namespace TrieBest
{
    public class Solution
    {
        int m, n;
        int[] dirx = { 1, 0, -1, 0 };
        int[] diry = { 0, 1, 0, -1 };

        public List<string> FindWords(char[][] board, string[] words)
        {
            m = board.Length;
            n = board[0].Length;
            Trie trie = new();
            foreach (var w in words) trie.Insert(w);
            HashSet<string> result = new();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    char cr = board[i][j];
                    if (trie.root.Contains(cr))
                    {
                        dfs(i, j, board, trie.root.GetRef(cr), result);
                    }
                }
            }
            return result.ToList();
        }
        void dfs(int r, int c, char[][] board, Node node, HashSet<string> result)
        {
            if (node.word != null)
            {
                result.Add(node.word);
                node.word = "null";
            }
            char temp = board[r][c];
            board[r][c] = '#';
            for (int i = 0; i < 4; i++)
            {
                int x = r + dirx[i];
                int y = c + diry[i];

                if (x >= 0 && y >= 0 && x < m && y < n && board[x][y] != '#')
                {
                    char cr = board[x][y];
                    if (node.Contains(cr))
                    {
                        dfs(x, y, board, node.GetRef(cr), result);
                    }
                }
            }
            board[r][c] = temp;
        }
    }
    class Node
    {
        public Node[] node = new Node[26];
        public string word = "null";
        public bool Contains(char cr)
        {
            return node[cr - 'a'] != null;
        }
        public Node GetRef(char cr)
        {
            return node[cr - 'a'];
        }
        public void Put(Node newNode, char cr)
        {
            node[cr - 'a'] = newNode;
        }
    }
    class Trie
    {
        public Node root = new Node();
        public void Insert(string str)
        {
            Node temp = root;
            for (int i = 0; i < str.Length; i++)
            {
                if (!temp.Contains(str[i]))
                {
                    temp.Put(new Node(), str[i]);
                }
                temp = temp.GetRef(str[i]);
            }
            temp.word = str;
        }
    }
}