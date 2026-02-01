namespace Dictionary
{
    public class ArrayAnagram:IProblem
    {
        public void Run()
        {
            int[] nums1={1,2,2,3};
            int[] nums2={3,2,1,2};
            Dictionary<int,int> freq1 =new();
            Dictionary<int,int> freq2 =new();
            foreach(int x in nums1)
            {
                freq1.TryGetValue(x,out int val);
                freq1[x]=val+1;
            }
            foreach(int x in nums2)
            {
                freq2.TryGetValue(x,out int val);
                freq2[x]=val+1;
            }
        //    foreach(var x in freq1)
        //     {
        //          if (!freq2.ContainsKey(x.Key))
        //             return false;

        //         if (freq2[x.Key] != x.Value)
        //             return false;
        //     }

        }
    }
}