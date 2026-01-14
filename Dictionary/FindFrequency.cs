using System.Xml.Serialization;

namespace Dictionary
{
    public class FindFrequency : IProblem
    {
        public void Run()
        {
            int[] nums = {4,4,4,5,5,6};
            Dictionary<int,int> freq =new Dictionary<int, int>();
            foreach(int num in nums)
            {
                if (!freq.ContainsKey(num))
                {
                    freq[num]=0;      
                }
                 freq[num]++;
            }
            foreach(var num in freq)
            {
                Console.WriteLine(num);
            }

        }
    }
}