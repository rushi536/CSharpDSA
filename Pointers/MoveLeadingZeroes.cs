namespace Pointers
{
    public class MoveLeadingZeroes : IProblem
    {
        public void Run()
        {
            int[] nums={0,1,0,3,12};
            int write=0;
            for(int read = 1; read < nums.Length; read++)
            {
                if (nums[read] != 0)
                {
                    nums[write]=nums[read];
                    write++;
                }
            }
            while (write < nums.Length)
            {
                nums[write]=0;
                write++;
            }
        }
    }
}