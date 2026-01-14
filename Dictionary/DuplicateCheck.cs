namespace Dictionary
{
    public class DuplicateCheck : IProblem
    {
        public void Run()
        {

            int[] nums = { 1, 2, 3, 1 };
            bool hasDuplicate = ContainsDuplicate(nums);
            Console.WriteLine(hasDuplicate);
        }
        private bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, bool> duplicateCheck = new();
            foreach (int num in nums)
            {
                if (duplicateCheck.ContainsKey(num))
                {
                    return true;
                }
                duplicateCheck[num] = true;
            }
            return false;
        }
    }
}