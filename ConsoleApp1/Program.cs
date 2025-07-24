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
            queue.Enqueue(30);
            Console.WriteLine(queue.Dequeue()); // Outputs: 10
            Console.WriteLine(queue.Dequeue()); // Outputs: 20
            queue.Enqueue(40);
            Console.WriteLine(queue.Dequeue()); // Outputs: 30
            Console.WriteLine(queue.Dequeue()); // Outputs: 40
            Console.WriteLine(queue.Dequeue()); // Outputs: Queue is empty
        }
    }
}