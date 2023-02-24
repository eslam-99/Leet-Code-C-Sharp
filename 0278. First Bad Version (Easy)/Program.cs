internal class Program
{
    private static void Main(string[] args)
    {
        Solution
        s = new(4);
        Console.WriteLine(s.FirstBadVersion(5));
        s = new(1702766719);
        Console.WriteLine(s.FirstBadVersion(2126753390));
        s = new(2147483647);
        Console.WriteLine(s.FirstBadVersion(2147483647));
    }
}