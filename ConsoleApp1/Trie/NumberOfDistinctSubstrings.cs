namespace TrieSolution
{
    class Solution
    {
        public int countSubs(string s)
        {
            int cnt = 0;
            int n = s.Length;
            Node root = new Node();
            for (int i = 0; i < n; i++)
            {
                Node temp = root;
                for (int j = i; j < n; j++)
                {
                    if (!temp.Contains(s[j]))
                    {
                        temp.Put(new Node(), s[j]);
                        cnt++;
                    }
                    temp = temp.GetRef(s[j]);
                }
            }
            return cnt;
        }
    }
    class Node
    {
        Node[] node;
        public Node()
        {
            node = new Node[26];
        }
        public bool Contains(char cr)
        {
            return node[cr - 'a'] != null;
        }
        public void Put(Node newNode, char cr)
        {
            node[cr - 'a'] = newNode;
        }
        public Node GetRef(char cr)
        {
            return node[cr - 'a'];
        }
    }
}