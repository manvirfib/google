namespace HelloWorld
{
    class BST
    {
        public TNode root;

        public void Inorder(TNode temp)
        {
            if (temp != null)
            {
                Inorder(temp.left);
                Console.WriteLine(temp.value);
                Inorder(temp.right);
            }
        }

        public void Inorder()
        {
            Inorder(root);
        }

        public int Height(TNode temp) {
            if (temp == null)
                return 0;
            int x = Height(temp.left);
            int y = Height(temp.right);

            if (x > y)
            {
                return x + 1;
            }
            else
            {
                return y + 1;
            }
        }

        TNode Pred(TNode ri)
        {
            while (ri != null && ri.right != null)
            {
                ri = ri.right;
            }
            return ri;
        }
        
        TNode Acc(TNode le)
        {
            while (le != null && le.left != null)
            {
                le = le.left;
            }
            return le;
        }

        public TNode Delete(TNode temp, int key)
        {
            if (temp == null)
            {
                return null;
            }
            if (temp.left == null && temp.right == null)
            {
                if (temp == root)
                {
                    root = null;
                }
                return null;
            }

            if (temp.value > key)
            {
                temp.left = Delete(temp.left, key);
            }
            else if (temp.value < key)
            {
                temp.right = Delete(temp.right, key);
            }
            else
            {
                if (Height(temp.left) > Height(temp.right))
                {
                    TNode p = Pred(temp.left);
                    temp.value = p.value;
                    temp.left = Delete(temp.left, p.value);
                }
                else
                {
                    TNode a = Acc(temp.right);
                    temp.value = a.value;
                    temp.right = Delete(temp.right, a.value);
                }
            }
            return temp;
        }

        public TNode RInsert(TNode temp, int key)
        {
            TNode p = null;

            if (temp == null)
            {
                p = new TNode() { value = key };
                if (root == null)
                {
                    root = p;
                }

                return p;
            }
            else
            {
                if (temp.value > key)
                {
                    temp.left = RInsert(temp.left, key);
                }
                else
                {
                    temp.right = RInsert(temp.right, key);
                }
            }

            return temp;
        }

        public TNode Search(int key)
        {
            TNode p = root;

            while (p != null)
            {
                if (p.value == key)
                {
                    return p;
                }
                if (p.value > key)
                {
                    p = p.left;
                }
                else
                {
                    p = p.right;
                }
            }

            return null;
        }

        public void Insert(int value)
        {
            TNode p = root, q = null;
            if (root == null)
            {
                root = new TNode() { value = value };
                return;
            }
            while (p != null)
            {
                if (value > p.value)
                {
                    q = p;
                    p = p.right;
                }
                else if (value < p.value)
                {
                    q = p;
                    p = p.left;
                }
                else
                {
                    return;
                }
            }
            var temp = new TNode() { value = value };

            if (value > q.value)
            {
                q.right = temp;
            }
            else
            {
                q.left = temp;
            }
        }
    }
}