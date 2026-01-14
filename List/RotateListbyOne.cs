namespace Lists
{
    public class RotateListbyOne : IProblem
    {
        public void Run()
        {
            List<int> list = new List<int> { 1, 2, 3, 4 };
            list.RemoveAt(0);
            list.Add(1);
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }
        }
    }
}