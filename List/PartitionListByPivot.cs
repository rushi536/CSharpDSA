namespace Lists
{
    public class PartitionListByPivot : IProblem
    {
        public void Run()
        {
            // List<int> list = new List<int> { 9, 12, 3, 5, 14, 10 };
            // int pivot = 10;
            // int left = 0;
            // int right = list.Count - 1;
            // int i = 0;
            // while (i <= right)
            // {
            //     if (list[i] < pivot)
            //     {
            //         int temp = list[left];
            //         list[left] = list[i];
            //         list[i] = temp;
            //         left++;
            //         i++;
            //     }
            //     else if (list[i] > pivot)
            //     {
            //         int temp = list[right];
            //         list[right] = list[i];
            //         list[i] = temp;
            //         right--;
            //     }
            //     else
            //     {
            //         i++; // equals pivot
            //     }
            // }
            // foreach (var x in list)
            // {
            //     Console.WriteLine(x);
            // }

            List<int> list = new List<int> { 2,0,2,1,1,0 };
            int pivot = 1;
            int left = 0;
            int right = list.Count - 1;
            int i = 0;
            while (i <= right)
            {
                if (list[i] < pivot)
                {
                    int temp = list[left];
                    list[left] = list[i];
                    list[i] = temp;
                    left++;
                    i++;
                }
                else if (list[i] > pivot)
                {
                    int temp = list[right];
                    list[right] = list[i];
                    list[i] = temp;
                    right--;
                }
                else
                {
                    i++; // equals pivot
                }
            }
            foreach (var x in list)
            {
                Console.WriteLine(x);
            }
        }
    }
}