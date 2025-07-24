namespace HelloWorld
{
    internal class Queue
    {
        int front = -1, rear = -1;
        int size;
        int[] array;
        public Queue(int size)
        {
            this.size = size;
            array = new int[size];
        }

        public void Enqueue(int value)
        {
            if (rear == size - 1)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            array[++rear] = value;
        }

        public int Dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            return array[++front];
        }
    }
}