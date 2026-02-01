namespace Dictionary
{
    public class AnagramCheck :IProblem
    {
        public void Run()
        {
            bool isstringAnagram=isAnagram();
            Console.WriteLine(isstringAnagram);
        }
        private bool isAnagram()
        {
            string input1="anagram";
            string input2="nagaram";
            Dictionary<char,int> freq1=new();
            Dictionary<char,int> freq2=new();
            if (input1.Length != input2.Length)
            {
                return false;
            }
            foreach (char item in input1)
            {
                freq1.TryGetValue(item,out int val);
                freq1[item]=val+1;
            }
            foreach (char item1 in input2)
            {
                freq2.TryGetValue(item1,out int val);
                freq2[item1]=val+1;
            }
            foreach(var x in input1)
            {
                if (freq1[x] == freq2[x])
                {
                    return true;
                }
            }
            return false;
        }
    }
}