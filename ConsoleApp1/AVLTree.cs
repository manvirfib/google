namespace HelloWorld
{
    class AVL
    {
        public TNode root;
        public TNode LLR(TNode temp)
        {
            TNode p, q;
            q = temp.left;
            p = q.right;
            q.right = temp;
            temp.left = p;

            temp.height = GetHeight(temp);
            q.height = GetHeight(q);

            if (q == root)
            {
                root = q;
            }

            return q;
        }

        public void InOrder(TNode node)
        {
            if (node != null)
            {
                InOrder(node.left);
                Console.Write(node.value + " ");
                InOrder(node.right);
            }
        }

        public TNode LRR(TNode temp)
        {
             TNode p, q;
            q = temp.left;
            p = q.right;

            q.right = p.left;
            temp.left = p.right;

            p.left = q;
            p.right = temp;

            q.height = GetHeight(q);
            temp.height = GetHeight(temp);
            p.height = GetHeight(p);

            if (p == root)
            {
                root = p;
            }

            return p;

        }

        public void RRR(TNode temp)
        {
            // Implement

        }

        public void RLR(TNode temp)
        {
            // Implement
        }

        public int GetHeight(TNode temp)
        {
            int left = temp.left != null ? temp.left.height : 0;
            int right = temp.right != null ? temp.right.height : 0;

            return left > right ? left + 1 : right + 1;
        }

        public int GetBalanceFactor(TNode temp) {
            int left = temp.left != null ? temp.left.height : 0;
            int right = temp.right != null ? temp.right.height : 0;

            return left - right;
        }

        public TNode RInsert(TNode temp, int val)
        {
            if (temp == null)
            {
                TNode p = new TNode() { value = val, height = 1 };
                if (root == null)
                {
                    root = p;
                }

                return p;
            }
            if (temp.value > val)
            {
                temp.left = RInsert(temp.left, val);
            }
            else if (temp.value < val)
            {
                temp.right = RInsert(temp.right, val);
            }

            temp.height = GetHeight(temp);

            int bf = GetBalanceFactor(temp);

            if (Math.Abs(bf) > 1)
            {
                if (bf == 2 && GetBalanceFactor(temp.left) == 1)
                {
                    return LLR(temp);
                }
                else if (bf == 2 && GetBalanceFactor(temp.left) == -1)
                {
                    LRR(temp);
                }
                else if (bf == -2 && GetBalanceFactor(temp.right) == -1)
                {
                    RRR(temp);
                }
                else if (bf == -2 && GetBalanceFactor(temp.right) == 1)
                {
                    RLR(temp);
                }
            }

            return temp;
        }
    }
}