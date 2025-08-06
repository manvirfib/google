namespace HelloWorld
{
    class BST
    {
        TNode root;

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