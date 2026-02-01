namespace Pointers
{
    public class ContainerWithMostWater : IProblem
    {
        public void Run()
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            int left = 0;
            int right = height.Length - 1;
            int maxWater = 0;

            while (left < right)
            {
                int area = Math.Min(height[left], height[right]) * (right - left);
                maxWater = Math.Max(maxWater, area);

                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            Console.WriteLine(maxWater);
        }
    }
}