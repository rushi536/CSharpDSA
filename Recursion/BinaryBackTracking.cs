namespace Pointers
{
    public class BinaryBackTracking : IProblem
    {
        public void Run()
        {
            int n = 2;
            List<string> result = new();
            Backtrack("", n, result);
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }

        }
        private void Backtrack(string path, int n, List<string> result)
        {
            if (path.Length == n)
            {
                result.Add(path);
                return;
            }
            Backtrack(path + "A", n, result);
            Backtrack(path + "B", n, result);
        }                                                                             
    }
}