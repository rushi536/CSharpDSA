namespace Pointers
{
    public class ThreeSumPointer : IProblem
    {
        public void Run()
        {

            int[] nums = { -4, -1, -1, 0, 1, 2 };
            int left = 0;
            int right = nums.Length - 1;
            int tragetSum = 9;
         while(left<right)
{
                if (nums[left] + nums[right] > tragetSum)
                {
                    right--;
                }
                else if (nums[left] + nums[right] < tragetSum)
                {
                    left++;
                }
            }
        }
    }
}