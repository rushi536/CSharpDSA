namespace Pointers
{
    public class TwoPointerTwoSum : IProblem
    {
        public void Run()
        {
           int[] nums= {2,7,11,15};
           int left=0;
           int right=nums.Length-1;
           int tragetSum=9;
           for(int i = 0; i < nums.Length; i++)
            {
               if(nums[left]+nums[right]>tragetSum)
                {
                    right--;
                }
                else if(nums[left]+nums[right]<tragetSum)
                {
                    left++;
                }
            } 
        }
    }
}