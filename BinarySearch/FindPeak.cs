namespace BinarySearch
{
    public class FindPeak : IProblem
    {
        public void Run()
        {
            int[] nums={1,2,3,1};
            int left=0;
            int right=nums.Length-1;
            while (left < right)
            {
                int mid=left+(right-left)/2;
                if (nums[mid] > nums[mid + 1])
                {
                    right=mid;
                }
                else
                {
                    left=mid+1;
                }
            }
            Console.WriteLine(left);
        }
    }
}