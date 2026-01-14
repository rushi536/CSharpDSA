namespace Strings;

public class IsPalindrome : IProblem
{
    public void Run()
    {
        string s = "madam";
        int left = 0;
        int right = s.Length - 1;

        bool isPal = true;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                isPal = false;
                break;
            }
            left++;
            right--;
        }

        Console.WriteLine($"\"{s}\" is palindrome? {isPal}");
    }
}