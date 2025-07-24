namespace HelloWorld
{
    class QueueUsing2Stacks
    {
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();

        public void Enqueue(int value)
        {
            stack1.Push(value);
        }

        public int Dequeue()
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }
            if (stack2.Count == 0)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            return stack2.Pop();
        }
    }
}