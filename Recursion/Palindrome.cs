using Strings;

namespace Recursion
{
    public class Palindrome:IProblem{
        public void Run()
        {
            string s="madam";
            bool checkPalindrome=IsPalindrome(s);
        }
        private bool IsPalindrome(string s)
        {
            if (s.Length <= 1)
            {
                return true;
            }
            if (s[0] != s[s.Length - 1])
            {
                return false;

            }
            return IsPalindrome(s.Substring(1,s.Length-2));
        }
    }
}