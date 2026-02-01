namespace Dictionary
{
    public class LongestSubstring : IProblem
    {
        public void Run()
        {
            string input = "abcabcbb";
            Dictionary<char, int> lastSeen = new();
            int start = 0;
            int maxLen = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (lastSeen.ContainsKey(c))
                {
                    start = Math.Max(start, lastSeen[c] + 1);
                }
                lastSeen[c] = i;
                maxLen = Math.Max(maxLen, i - start + 1);
            }

            Console.WriteLine(maxLen);

        }
    }
}