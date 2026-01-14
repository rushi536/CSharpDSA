using Arrays;
using Strings;
using Patterns;
using Lists;
using Dictionary;

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
             { 9, ("Fidning Duplicate in dictionary", new DuplicateCheck()) }
        };
}