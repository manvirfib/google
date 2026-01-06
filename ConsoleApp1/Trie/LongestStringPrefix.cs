namespace Trie
{
    public class TrieSolution
    {
        public string LongestValidWord(string[] words)
        {
            Trie trie = new Trie();
            foreach (var word in words)
            {
                trie.Insert(word);
            }
            return trie.Search(words);
        }
    }

    public class Node
    {
        public Node[] node = new Node[26];
        public bool flag = false;

        public bool Contains(char ch)
        {
            return node[ch - 'a'] != null;
        }

        public void Put(Node newNode, char ch)
        {
            node[ch - 'a'] = newNode;
        }

        public Node GetRef(char ch)
        {
            return node[ch - 'a'];
        }

        public void SetEndWord()
        {
            flag = true;
        }

        public bool GetFlag()
        {
            return flag;
        }
    }

    public class Trie
    {
        private Node root;

        public Trie()
        {
            root = new Node();
        }

        public void Insert(string s)
        {
            Node temp = root;
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (!temp.Contains(ch))
                {
                    temp.Put(new Node(), ch);
                }
                temp = temp.GetRef(ch);
            }
            temp.SetEndWord();
        }

        public string Search(string[] strs)
        {
            string res = "";

            foreach (string temp in strs)
            {
                Node p = root;
                bool valid = true;

                for (int j = 0; j < temp.Length; j++)
                {
                    char ch = temp[j];

                    if (!p.Contains(ch))
                    {
                        valid = false;
                        break;
                    }

                    p = p.GetRef(ch);

                    if (!p.GetFlag())
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                {
                    if (temp.Length > res.Length ||
                       (temp.Length == res.Length &&
                        string.Compare(temp, res, StringComparison.Ordinal) < 0))
                    {
                        res = temp;
                    }
                }
            }
            return res;
        }
    }
}
