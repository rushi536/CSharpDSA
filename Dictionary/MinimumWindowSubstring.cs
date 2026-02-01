namespace Dictionary
{
    public class MinimumWindowSubstring:IProblem
    {
        public void Run()
        {
            int[] nums ={1,1,2,2,3};
            int write=0;
            for(int read = 1; read < nums.Length; read++)
            {
                if (nums[read] != nums[write])
                {
                            write++;
                    nums[write]=nums[read];
            
                }
            }
            Console.Write(write+1);
        }
    }
}