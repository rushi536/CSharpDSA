namespace StackQueue
{
    public class Stack:IProblem
    {
        public void Run()
        {
            Stack<int> stack=new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
        }
    }
}