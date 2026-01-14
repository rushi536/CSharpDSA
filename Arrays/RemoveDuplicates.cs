namespace Arrays;

public class RemoveDuplicates : IProblem
{
    public void Run()
    {
        int[] nums = { 1, 1, 2, 2, 3 };
        int write = 1;

        for (int read = 1; read < nums.Length; read++)
        {
            if (nums[read] != nums[write - 1])
            {
                nums[write++] = nums[read];
            }
        }

        Console.Write("Result: ");
        for (int i = 0; i < write; i++)
            Console.Write(nums[i] + " ");
    }
}