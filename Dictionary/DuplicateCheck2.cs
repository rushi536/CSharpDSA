namespace Dictionary
{
    public class DuplicateCheck2:IProblem
    {
        public void Run()
        {
           bool isavailable=ContaineDulicate();
           Console.WriteLine(isavailable);
        }

        private bool ContaineDulicate()
        {
              int[] nums={5,3,6,5,2};
             Dictionary<int,int> lastSeen= new();
            int k=3;
            for(int i = 0; i < nums.Length; i++)
            {
                int current=nums[i];
                if (lastSeen.ContainsKey(current))
                {
                    if (i - lastSeen[current] <= k)
                    {
                        return true;
                    }
                }
                lastSeen[current]=i;
            }
            return false;
        }




    }
}