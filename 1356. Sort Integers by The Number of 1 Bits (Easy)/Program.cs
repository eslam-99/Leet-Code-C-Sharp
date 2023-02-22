internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        Console.WriteLine(string.Join(',', s.SortByBits(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 })));
        Console.WriteLine(string.Join(',', s.SortByBits(new int[] { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 })));
    }
}