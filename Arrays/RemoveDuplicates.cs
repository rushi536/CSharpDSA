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

    // Code for unsorted Array to remove duplicates in place.

    // public int RemoveDuplicates(int[] nums)
    // {
    //     if (nums == null || nums.Length == 0)
    //         return 0;

    //     int write = 0;

    //     for (int i = 0; i < nums.Length; i++)
    //     {
    //         bool isDuplicate = false;

    //         // Check if nums[i] already exists in [0...write-1]
    //         for (int j = 0; j < write; j++)
    //         {
    //             if (nums[j] == nums[i])
    //             {
    //                 isDuplicate = true;
    //                 break;
    //             }
    //         }

    //         // If not duplicate, place it at write index
    //         if (!isDuplicate)
    //         {
    //             nums[write] = nums[i];
    //             write++;
    //         }
    //     }

    //     return write;
    // }
}