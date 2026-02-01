namespace Dictionary
{
    public class StringFrequency :IProblem
    {
        public void Run()
        {
            string inputWord="mississippi";
            Dictionary<char,int> strFreq=new();
            foreach(char x in inputWord)
            {
                if(!strFreq.ContainsKey(x))
                {
                    strFreq[x]=0;
                }
                strFreq[x]++;
            }
             foreach(var x in strFreq)
            {
                Console.WriteLine(x);
            }
        }
    }
    
}