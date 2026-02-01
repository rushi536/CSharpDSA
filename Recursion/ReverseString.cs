namespace Recursion
{
    public class ReverseString:IProblem
    {
        public void Run()
        {
            string s="hello";
            string reversedString=Reverse(s);
            Console.WriteLine(reversedString);
        }
        private string Reverse(string s)
        {
            if (s.Length == 0)
            {
                return "";
            }
          char lastChar=s[s.Length-1];
          string remaining=s.Substring(0,s.Length-1);
         
           return lastChar+Reverse(remaining);
        }
    }
}