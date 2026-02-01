namespace Dictionary
{
    public class FindNonRepeatingCharacter : IProblem
    {
        public void Run()
        {
            string input = "lleetcode";
            char result = NonRepeatChar(input);
            Console.WriteLine(result);

        }
        private char NonRepeatChar(string input)
        {
            Dictionary<char, int> keyValuePairs = new();
            foreach (var x in input)
            {
                keyValuePairs.TryGetValue(x, out int val);
                keyValuePairs[x] = val + 1;
            }
            foreach (var x in input)
            {
                if (keyValuePairs[x] == 1)
                {
                   return x; 
                }
            }
            return '-';
        }
    }
}