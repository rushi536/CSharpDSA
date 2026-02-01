namespace Pointers
{
    public class PalindromeCheck : IProblem
    {
        public void Run()
        {
            string s="A man, a plan, a canal: Panama".ToLower();
           bool isvalidPalindrome=isPalindrome(s);
        }
        private bool isPalindrome(string s)
        {
             int left=0;
            int right=s.Length-1;
            while (left >= right)
            {
                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                else if (!char.IsLetterOrDigit(s[right]))
                {
                    right --;

                }
                else if (s[left] != s[right])
                {
                    return false;
                }
                else
                {
                    left++;
                    right--;
                }
            }
            return true;
        }
    }
}