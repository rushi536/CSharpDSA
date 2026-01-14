namespace Patterns;

public class Pattern1 : IProblem
{
    public void Run()
    {
        int n = 5;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write("* ");

            Console.WriteLine();
        }
    }
}