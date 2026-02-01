namespace Dictionary
{
    public class CharacterFrequencySort:IProblem
    {
        public void Run()
        {
            string input = "banana";
            Dictionary<char, int> charFreq = new();
            foreach (char c in input)
            {
                charFreq.TryGetValue(c, out int val);
                charFreq[c] = val + 1;
            }
            foreach(var x in charFreq){
            Console.WriteLine($"{x.Key} and {x.Value}");
            }
        }
    }
}