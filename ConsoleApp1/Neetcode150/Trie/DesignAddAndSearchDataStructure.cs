namespace Dictionary
{
    public class WordDictionary
    {
        Trie trie;
        public WordDictionary()
        {
            trie = new Trie();
        }

        public void AddWord(string word)
        {
            trie.Insert(word);
        }

        public bool Search(string word)
        {
            return trie.Search(word);
        }
    }
    class Node
    {
        Node[] node;
        bool flag;
        public Node()
        {
            node = new Node[26];
        }
        public bool Contains(char c)
        {
            return node[c - 'a'] != null;
        }
        public Node GetRef(char c)
        {
            return node[c - 'a'];
        }
        public void Put(Node newNode, char c)
        {
            node[c - 'a'] = newNode;
        }
        public void SetFlag()
        {
            flag = true;
        }
        public bool GetFlag()
        {
            return flag;
        }
    }
    class Trie
    {
        Node root;
        public Trie()
        {
            root = new Node();
        }
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
            temp.SetFlag();
        }
        public bool Search(string word)
        {
            Node temp = root;
            return dfs(0, temp, word);
        }
        public bool dfs(int idx, Node r, string word)
        {
            if (idx == word.Length)
            {
                return r.GetFlag();
            }
            if (word[idx] == '.')
            {
                for (char i = 'a'; i <= 'z'; i++)
                {
                    Node refer = r.GetRef(i);
                    if (refer != null)
                    {
                        if (dfs(idx + 1, refer, word)) return true;
                    }
                }
            }
            else
            {
                if (r.GetRef(word[idx]) != null)
                {
                    return dfs(idx + 1, r.GetRef(word[idx]), word);
                }
                return false;
            }
            return false;
        }
    }
}