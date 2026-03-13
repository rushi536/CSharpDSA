namespace BinarySearch
{
    public class FirstAndLastOccurance : IProblem
    {
        public void Run()
        {
            int[] nums = { 1, 1, 2, 2, 2 };
            int target = 2;
            int left = 0;
            int right = nums.Length;
            int answer = -1;
            while (left <= right)
            {
                int mid = left + right / 2;
                if (nums[mid] == target)
                {
                    answer = mid;
                    left = mid + 1;
                }
                else if (nums[mid] <= target)
                {
                      left = mid + 1;
                  
               
                }
                else
                {
                      right = mid - 1;   
                }
            }
            Console.WriteLine(answer);
        }
    }
}