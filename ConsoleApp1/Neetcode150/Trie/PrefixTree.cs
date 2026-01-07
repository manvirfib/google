namespace prefixtree
{
    class Node
    {
        Node[] node;
        bool flag;
        public Node()
        {
            node = new Node[26];
        }
        public bool ContainsChar(char cr)
        {
            return node[cr - 'a'] != null;
        }
        public Node GetRef(char cr)
        {
            return node[cr - 'a'];
        }
        public void PutData(Node newNode, char cr)
        {
            node[cr - 'a'] = newNode;
        }
        public void FinishString()
        {
            flag = true;
        }
        public bool IsFinished()
        {
            return flag;
        }
    }
    public class PrefixTree
    {
        Node root;

        public PrefixTree()
        {
            root = new Node();
        }

        public void Insert(string word)
        {
            Node temp = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (!temp.ContainsChar(word[i]))
                {
                    temp.PutData(new Node(), word[i]);
                }
                temp = temp.GetRef(word[i]);
            }
            temp.FinishString();
        }

        public bool Search(string word)
        {
            Node temp = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (!temp.ContainsChar(word[i]))
                {
                    return false;
                }
                temp = temp.GetRef(word[i]);
            }
            return temp.IsFinished();
        }

        public bool StartsWith(string prefix)
        {
            Node temp = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                if (!temp.ContainsChar(prefix[i]))
                {
                    return false;
                }
                temp = temp.GetRef(prefix[i]);
            }
            return true;
        }
    }
}