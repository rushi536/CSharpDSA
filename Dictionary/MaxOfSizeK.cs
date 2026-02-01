using System.Diagnostics.CodeAnalysis;

namespace Dictionary
{
    public class MaxOfSizeK : IProblem
    {
        public void Run()
        {
            // int[] nums = { 2, 1, 5, 1, 3, 2 };
            // int k = 3;
            // int windowSum = 0;
            // int maxSum = 0;
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     windowSum += nums[i];
            //     if (i >= k - 1)
            //     {
            //         maxSum = Math.Max(maxSum, windowSum);
            //         windowSum -= nums[i - k + 1];

            //     }
            // }

             int[] nums = { 1, 3, 2, 6, -1, 4, 1, 8, 2 };
            int k = 5;
            int windowSum = 0;
            float maxSum = 0;
            float [] avgArray= new float[10];
            int j=0;
            for (int i = 0; i < nums.Length; i++)
            {
                windowSum += nums[i];
                if (i >= k - 1)
                {
                    maxSum =windowSum/k;
                    windowSum -= nums[i - k + 1];
                    avgArray[j]=maxSum;
                    j++;
                }
            }
        }

    }
}