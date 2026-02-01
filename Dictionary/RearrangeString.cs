using System.Security.AccessControl;

namespace Dictionary
{
    public class RearrangeString : IProblem
    {
        public void Run()
        {
            bool stringAnagram = isStringAnagram();
            Console.WriteLine(stringAnagram);


        }
        private bool isStringAnagram()
        {
            string input1 = "abcde";
            string input2 = "edcba";
            Dictionary<char, int> freq1 = new();
            Dictionary<char, int> freq2 = new();
            foreach (var x in input1)
            {
                freq1.TryGetValue(x, out int val);
                freq1[x] = val + 1;
            }
            foreach (var x in input2)
            {
                freq1.TryGetValue(x, out int val);
                freq1[x] = val + 1;
            }
            foreach (var pair in freq1)
            {
                if (!freq2.ContainsKey(pair.Key))
                    return false;

                if (freq2[pair.Key] != pair.Value)
                    return false;
            }
            return false;
        }
    }
}