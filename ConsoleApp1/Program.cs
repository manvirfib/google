namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueUsing2Stacks queue = new QueueUsing2Stacks();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(10);
            queue.Enqueue(20);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue()); // Should print "List is empty" and return -
        }
    }
}