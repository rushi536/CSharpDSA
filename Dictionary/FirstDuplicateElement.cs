namespace Dictionary
{
    public class FirstDuplicateElement : IProblem
    {
        public void Run()
        {
            int[] nums = { 2, 1, 3, 2, 5, 3, 2 };

            int duplicateNum = FindDuplicateNum(nums);
            Console.WriteLine($"The first Duplicate Number is :{duplicateNum}");

        }
        private int FindDuplicateNum(int[] nums)
        {
            Dictionary<int, int> duplicateCheck = new();
            foreach (int num in nums)
            {
                if (duplicateCheck.ContainsKey(num))
                {
                    return num;
                }
                duplicateCheck[num] = 1;
            }
            return 0;
        }
    }
}