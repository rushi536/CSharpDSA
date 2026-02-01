using Arrays;
using Strings;
using Patterns;
using Lists;
using Dictionary;
using Pointers;
using Recursion;

public static class ProblemRegistry
{
    public static Dictionary<int, (string Name, IProblem Problem)> Problems =
        new()
        {
            { 1, ("Remove Duplicates from Sorted Array", new RemoveDuplicates()) },
            { 2, ("Palindrome Check (String)", new IsPalindrome()) },
            { 3, ("Pattern Printing - Basic", new Pattern1()) },
            { 4, ("Find even Number from Array", new FindEvenNumber()) },
            { 5, ("Rotate List by 1 Digit", new RotateListbyOne()) },
             { 6, ("Move All Zeroes to End", new MoveAllZeroesToEnd()) },
             { 7, ("Partition list by pivot", new PartitionListByPivot()) },
             { 8, ("Frequency suing Dictionary", new FindFrequency()) },
             { 9, ("Fidning Duplicate in dictionary", new DuplicateCheck()) },
             { 10, ("Frequncey count of string in dictionary", new StringFrequency()) },
             { 11, ("Frequncey count of string in dictionary", new FirstDuplicateElement()) },
             { 12, ("Frequncey count of string in dictionary", new FindAllUniqueElements()) },
             { 13, ("Find Non repeating chracter", new FindNonRepeatingCharacter()) },
             { 14, ("Character frequncey sorting", new CharacterFrequencySort()) },
             { 15, ("Anagram check", new AnagramCheck()) },
             { 16, ("Array Anagram check", new ArrayAnagram()) },
             { 17, ("Longest substring", new LongestSubstring()) },
             { 18, ("Longest substring with Atmost K", new LongSubStringAtMostK()) },
             { 19, ("Variable size sliding window", new VariableSizeSlidignWindow()) },
             { 20, ("POinter ", new MinimumWindowSubstring()) },
             { 21, ("Container With Most Water ", new ContainerWithMostWater()) },
             { 22, ("Reverse string using Recursion ", new ReverseString()) }
        };
}