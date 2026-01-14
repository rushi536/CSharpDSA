
public class FindEvenNumber : IProblem
{
    public void Run()
    {//Finding Even element in an array
        int[] arr =
        {1,6,8,
            2,410,
            5,
            3
        };
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count++;
            }
        }
        Console.Write(count);

    }
}