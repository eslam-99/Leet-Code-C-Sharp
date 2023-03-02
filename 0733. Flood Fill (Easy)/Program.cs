internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        int[][] img = new int[3][]
        {
            new int[] { 1, 1, 1 },
            new int[] { 1, 1, 0 },
            new int[] { 1, 0, 1 }
        };
        img = s.FloodFill(img, 1, 1, 2);
        Console.WriteLine(string.Join('\n', img.Select(x => string.Join(',', x))));

        img = new int[2][]
        {
            new int[] { 0, 0, 0 },
            new int[] { 0, 0, 0 }
        };
        img = s.FloodFill(img, 0, 0, 0);
        Console.WriteLine(string.Join('\n', img.Select(x => string.Join(',', x))));
    }
}