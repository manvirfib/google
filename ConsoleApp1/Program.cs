namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue queue = new PriorityQueue();
            queue.Enqueue(10, 2);
            queue.Enqueue(20, 1);
            queue.Enqueue(10, 2);
            queue.Enqueue(20, 3);
            queue.Enqueue(10, 2);
            queue.Enqueue(20, 2);
            queue.Enqueue(10, 1);
            queue.Enqueue(20, 1);
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