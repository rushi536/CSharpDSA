namespace Dictionary
{
    public class LongSubStringAtMostK : IProblem
    {
        public void Run()
        {
            string s = "eceba";
            int k = 2;

            int left = 0;
            int maxLen = 0;

            Dictionary<char, int> freq = new();

            for (int right = 0; right < s.Length; right++)
            {
                char current = s[right];

                // expand window
                freq.TryGetValue(current, out int val);
                freq[current] = val + 1;

                // shrink window if invalid
                while (freq.Count > k)
                {
                    char leftChar = s[left];
                    freq[leftChar]--;

                    if (freq[leftChar] == 0)
                    {
                        freq.Remove(leftChar);
                    }

                    left++;
                }

                // update result when window is valid
                maxLen = Math.Max(maxLen, right - left + 1);
            }

            Console.WriteLine(maxLen);
        }
    }
}