namespace HelloWorld
{
    class PriorityQueue
    {
        LinkedList<int> list1 = new LinkedList<int>();
        LinkedList<int> list2 = new LinkedList<int>();
        LinkedList<int> list3 = new LinkedList<int>();
        public void Enqueue(int value, int p)
        {
            if (p == 1)
            {
                list1.AddLast(value);
            }
            else if (p == 2)
            {
                list2.AddLast(value);
            }
            else
            {
                list3.AddLast(value);
            }
        }

        public int Dequeue()
        {
            if (list1.Count > 0)
            {
                int value = list1.First.Value;
                list1.RemoveFirst();
                return value;
            }
            else if (list2.Count > 0)
            {
                int value = list2.First.Value;
                list2.RemoveFirst();
                return value;
            }
            else if (list3.Count > 0)
            {
                int value = list3.First.Value;
                list3.RemoveFirst();
                return value;
            }
            else
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
        }
    }
}