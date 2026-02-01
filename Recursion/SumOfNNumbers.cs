namespace Recursion
{
    public class SumOfNNumbers : IProblem
    {
        public void Run()
        {
            int result = Sum(5);
            Console.WriteLine(result);
        }
        private int Sum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n + Sum(n - 1);
        }
    }
}