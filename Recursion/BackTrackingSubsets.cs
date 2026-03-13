namespace Recursion
{
    public class BackTrackingSubsets : IProblem
    {
        public void Run()
        {
            int[] nums={1,2};
            List<List<int>> result=new();
            List<int> path= new();
            bool[] used =new bool[nums.Length];
            Backtrack(nums,path,used,result);
            foreach(var perm in result)
            {
                Console.WriteLine($"[{string.Join(",",perm)}]");
            }

        }
        private void Backtrack(int[] nums,List<int> path, bool[] used, List<List<int>> result)
        {
            if (path.Count == nums.Length)
            {
                result.Add(new List<int>(path));
                return;
            }
            for(int i = 0; i < nums.Length; i++)
            {
                if(used[i])
                continue;
                path.Add(nums[i]);
                used[i]=true;
                Backtrack(nums,path,used,result);
                path.RemoveAt(path.Count-1);
                used[i]=false;
                
            }

        }
    }
}