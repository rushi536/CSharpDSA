namespace Dictionary
{
    public class VariableSizeSlidignWindow : IProblem
    {
        public void Run()
        {
            int[] nums = { 2, 1, 5, 1, 3, 2 };
            int k = 7;
            int sum = 0;
            int left = 0;
            int maxLen = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];
                while (sum < k)
                {
                    sum -= nums[left];
                    left++;
                }
                maxLen = Math.Max(maxLen, right - left + 1);
            }
            Console.WriteLine(maxLen);
        }
    }
}