internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        var chars = "aaabbaa".ToCharArray();
        Console.WriteLine(s.Compress(chars));
        Console.WriteLine(string.Join("", chars));

        chars = "abc".ToCharArray();
        Console.WriteLine(s.Compress(chars));
        Console.WriteLine(string.Join("", chars));
    }
}