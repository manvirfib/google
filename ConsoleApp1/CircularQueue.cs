using System;

namespace HelloWorld
{
    class CircularQueue
    {
        int front = 0, rear = 0, size;
        int[] array;
        public CircularQueue(int size)
        {
            this.size = size;
            array = new int[size];
        }

        public void Enqueue(int value)
        {
            if ((rear + 1) % size == front)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            rear = (rear + 1) % size;
            array[rear] = value;
        }

        public int Dequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            front = (front + 1) % size;
            return array[front];
        }
    }
}