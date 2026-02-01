namespace Dictionary
{
    public class FindAllUniqueElements : IProblem
    {
        public void Run()
        {
            int[] nums = { 1,2,3,4 };

            bool duplicateNum = isUnique(nums);
            Console.WriteLine(duplicateNum);

        }
        private bool isUnique(int[] nums)
        {
            Dictionary<int, bool> seen = new();
            foreach (int num in nums)
            {
                if (seen.ContainsKey(num))
                {
                    return false;
                }
                seen[num] = true;
            }
            return true;
        }
    }
}