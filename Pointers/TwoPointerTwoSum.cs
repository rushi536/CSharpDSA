using System.Runtime;

namespace Pointers
{
    public class TwoPointerTwoSum : IProblem
    {
        public void Run()
        {
            int[] nums = { 2, 7, 11, 15 };
            int left = 0;
            int right = nums.Length - 1;
            int target = 9;
            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum > target)
                {
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    Console.WriteLine($"{left},{right}");
                    break;
                }
            }
        }
    }
}
