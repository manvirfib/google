namespace MaximumTrie
{
    public class Solution
    {
        public int FindMaximumXOR(int[] nums)
        {
            Node root = new Node();
            int max = 0;
            foreach (var num in nums)
            {
                Node temp = root;
                for (int i = 31; i >= 0; i--)
                {
                    int bit = (num >> i) & 1;
                    if (!temp.Contains(bit))
                    {
                        temp.Put(new Node(), bit);
                    }
                    temp = temp.GetRef(bit);
                }
            }

            foreach (var num in nums)
            {
                Node temp = root;
                int cur = 0;
                for (int i = 31; i >= 0; i--)
                {
                    int bit = (num >> i) & 1;
                    if (temp.Contains(1 - bit))
                    {
                        cur |= (1 << i);
                        temp = temp.GetRef(1 - bit);
                    }
                    else
                    {
                        temp = temp.GetRef(bit);
                    }
                }
                max = Math.Max(max, cur);
            }

            return max;
        }
    }
    class Node
    {
        Node[] node;
        public Node()
        {
            node = new Node[2];
        }
        public void Put(Node newNode, int bit)
        {
            node[bit] = newNode;
        }
        public bool Contains(int bit)
        {
            return node[bit] != null;
        }
        public Node GetRef(int bit)
        {
            return node[bit];
        }
    }
}