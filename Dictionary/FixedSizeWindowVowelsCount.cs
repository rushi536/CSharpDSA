// namespace Dictionary
// {
//     public class FixedSizeWindowVowelsCount : IProblem
//     {
//         public void Run()
//         {
//             HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };

//             int currentVowels = 0;
//             int maxVowels = 0;
//             string s = "aebcdeaii";
//             int k = 3;

//             for (int i = 0; i < s.Length; i++)
//             {
//                 // add incoming character
//                 if (vowels.Contains(s[i]))
//                 {
//                     currentVowels++;
//                 }

//                 // when window size reaches k
//                 if (i >= k - 1)
//                 {
//                     maxVowels = Math.Max(maxVowels, currentVowels);

//                     // remove outgoing character
//                     if (vowels.Contains(s[i - k + 1]))
//                     {
//                         currentVowels--;
//                     }
//                 }
//             }

//             //return maxVowels;
//         }
//     }
