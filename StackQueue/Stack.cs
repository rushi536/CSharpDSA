namespace StackQueue
{
    public class Stack : IProblem
    {
        public void Run()
        {
            StackExample();
            QueueExample();
        }

        public void StackExample()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine($"Before Popping {stack.Peek()}");
            Console.WriteLine($"Pop the element {stack.Pop()}");
            Console.WriteLine($"After poping element {stack.Peek()}");
        }

        public void QueueExample()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            Console.WriteLine($"initial queue {queue.Peek()}");
            queue.Dequeue();
            Console.WriteLine($"After Dequeue {queue.Peek()}");
        }
    }
}

