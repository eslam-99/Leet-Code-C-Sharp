internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        Console.WriteLine(s.OrangesRotting(
            new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 0, 1, 1 }
            }
        ));
        Console.WriteLine(s.OrangesRotting(
            new int[][]
            {
                new int[] { 2, 1, 1 },
                new int[] { 0, 1, 1 },
                new int[] { 1, 0, 1 },
            }
        ));
    }
}