internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        Console.WriteLine(string.Join('\n', s.LetterCasePermutation("ab")));
        Console.WriteLine();
        Console.WriteLine(string.Join('\n', s.LetterCasePermutation("a1b2")));
    }
}