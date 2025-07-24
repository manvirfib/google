namespace HelloWorld
{
    class Node
    {
        public int value;
        public Node next;
    }
    class LinkedList
    {
        Node head;
        Node tail;

        public void Add(int value)
        {
            Node newNode = new Node { value = value, next = null };
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
        }

        public int RemoveFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return -1;
            }
            int val = head.value;
            head = head.next;

            if (head == null)
            {
                tail = null; // If the list becomes empty, reset tail
            }
            return val;
        }
    }
}