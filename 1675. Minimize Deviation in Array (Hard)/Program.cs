internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        Console.WriteLine(s.MinimumDeviation(new int[] { 1, 2, 3, 4 }) + " : 1");
        Console.WriteLine(s.MinimumDeviation(new int[] { 4, 1, 5, 20, 3 }) + " : 3");
        Console.WriteLine(s.MinimumDeviation(new int[] { 2, 10, 8 }) + " : 3");
        Console.WriteLine(s.MinimumDeviation(new int[] { 4, 9, 4, 5 }) + " : 5");
        Console.WriteLine(s.MinimumDeviation(new int[] { 2, 8, 6, 1, 6 }) + " : 1");
        Console.WriteLine(s.MinimumDeviation(new int[] { 10, 4, 3 }) + " : 2");
    }
}