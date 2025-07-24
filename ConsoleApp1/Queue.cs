using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(5);
            queue.Enqueue(10);
            queue.Enqueue(20);
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue(30);
            queue.Enqueue(40);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }

    class Queue
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