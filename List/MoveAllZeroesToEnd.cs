using System.ComponentModel;

namespace Lists
{
    public class MoveAllZeroesToEnd : IProblem
    {
        public void Run()
        {
             List<int> list= new List<int>{0,1,0,3,12};

            // for(int i= list.Count-1; i >=0; i--)
            // {
            //     if (list[i] == 0)
            //     {
            //   list.RemoveAt(i);
            //   list.Add(0);
            //     }
            // }
            // foreach(var x in list)
            // {
            //     Console.WriteLine(x);
            // }


            int write =0;
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] != 0)
                {
                    list[write]=list[i];
                    write++;
                }

            }
            for(int i = list.Count-1; i>=write; i--)
            {
                list.RemoveAt(i);
                list.Add(0);
            }
            foreach(var x in list)
            {
                Console.WriteLine(x);
            }
        }
    }
}