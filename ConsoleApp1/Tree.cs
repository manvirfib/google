namespace HelloWorld
{
    class TNode
    {
        public int value;
        public TNode left, right;
    }

    class Tree
    {
        public TNode root = null;
        public TNode Create()
        {
            Console.WriteLine("Please enter the root value: ");
            int val = int.Parse(Console.ReadLine());
            root = new TNode() { value = val };

            Queue<TNode> q = new Queue<TNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                TNode temp = q.Dequeue();
                Console.WriteLine("Please enter the left child of: " + temp.value);
                int l = int.Parse(Console.ReadLine());
                if (l != -1)
                {
                    TNode rd = new TNode() { value = l };
                    temp.left = rd;
                    q.Enqueue(rd);
                }
                Console.WriteLine("Please enter the right child of: " + temp.value);
                int r = int.Parse(Console.ReadLine());
                if (r != -1)
                {
                    TNode rd = new TNode() { value = r };
                    temp.right = rd;
                    q.Enqueue(rd);
                }
            }

            return root;
        }

        public void IPreOrder(TNode root)
        {
            Stack<TNode> stack = new Stack<TNode>();
            stack.Push(root);
            TNode temp;

            Console.WriteLine();

            while (stack.Count > 0)
            {
                temp = stack.Pop();
                Console.Write(temp.value + " ");

                if (temp.right != null)
                    stack.Push(temp.right);

                if (temp.left != null)
                    stack.Push(temp.left);
            }
        }

        public void PreOrder(TNode node)
        {
            if (node != null)
            {
                Console.Write(node.value + " ");
                PreOrder(node.left);
                PreOrder(node.right);
            }
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

        public void IInOrder(TNode root)
        {
            Stack<TNode> stack = new Stack<TNode>();
            TNode temp = root;

            Console.WriteLine();

            while (temp != null || stack.Count > 0)
            {
                if (temp != null)
                {
                    stack.Push(temp);
                    temp = temp.left;
                }
                else
                {
                    temp = stack.Pop();
                    Console.Write(temp.value + " ");
                    temp = temp.right;
                }
            }
        }

        public void PostOrder(TNode node)
        {
            if (node != null)
            {
                PreOrder(node.left);
                PreOrder(node.right);
                Console.Write(node.value + " ");
            }
        }

        public void LevelOrder(TNode root)
        {
            Queue<TNode> pos = new Queue<TNode>();
            pos.Enqueue(root);
            TNode temp;

            Console.WriteLine();

            while (pos.Count > 0)
            {
                temp = pos.Dequeue();
                Console.Write(temp.value + " ");

                if (temp.left != null)
                {
                    pos.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    pos.Enqueue(temp.right);
                }
            }
        }
    }
}