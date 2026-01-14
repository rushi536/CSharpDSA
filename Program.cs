class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("===== C# DSA PRACTICE =====\n");

        foreach (var p in ProblemRegistry.Problems)
            Console.WriteLine($"{p.Key}. {p.Value.Name}");

        Console.Write("\nEnter problem number: ");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("\n----- OUTPUT -----\n");
        ProblemRegistry.Problems[choice].Problem.Run();

        Console.WriteLine("\n\nPress any key to exit...");
        Console.ReadLine();
    }
}