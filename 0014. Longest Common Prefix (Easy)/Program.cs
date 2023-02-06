internal partial class Program
{
    private static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
        Console.WriteLine(s.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
        Console.WriteLine(s.LongestCommonPrefix(new string[] { "a" }));
        Console.WriteLine(s.LongestCommonPrefix(new string[] { "reflower", "flow", "flight" }));
    }
}