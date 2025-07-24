using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueUsingLL queue = new QueueUsingLL();
            queue.Enqueue(10);
            queue.Enqueue(20);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue()); // Should print "List is empty" and return -
        }
    }
}