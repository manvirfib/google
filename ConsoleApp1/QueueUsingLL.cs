namespace HelloWorld
{
    class QueueUsingLL
    {
        LinkedList list = new LinkedList();

        public void Enqueue(int value)
        {
            list.Add(value);
        }

        public int Dequeue()
        {
            return list.RemoveFirst();
        }
    }
}