namespace HelloWorld
{
    class BST
    {
        TNode root;

        public TNode Insert(TNode temp, int value)
        {
            TNode t = null;
            
            if (temp == null)
            {
                t = new TNode() { value = value };
                return t;
            }

            if (temp.value > value)
            {
                temp.right = Insert(temp.right, value);
            }
            else if (temp.value < value)
            {
                temp.left = Insert(temp.left, value);
            }

            return t;
        }

        public void Create()
        {
            Console.WriteLine("Please enter the root node");
            int num = int.Parse(Console.ReadLine());

            root = new TNode() { value = num };
            TNode temp = root;

            while (1 == 1)
            {
                Console.WriteLine("Insert element: 0/1");
                int decision = int.Parse(Console.ReadLine());
                if (decision == 0)
                {
                    break;
                }
                Console.WriteLine("Enter the number: ");
                int treeNum = int.Parse(Console.ReadLine());

                TNode element = new TNode() { value = treeNum };

                while (temp != null)
                {
                    if (treeNum > temp.value)
                    {
                        if (temp.right == null)
                        {
                            temp.right = element;
                        }
                        else
                        {
                            temp = temp.right;
                        }
                    }
                    else
                    {
                        if (temp.left == null)
                        {
                            temp.left = element;
                        }
                        else
                        {
                            temp = temp.left;
                        }
                    }
                }
            }
        }
    }
}