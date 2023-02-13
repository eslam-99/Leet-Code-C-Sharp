internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        Console.WriteLine(s.MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        Console.WriteLine(s.MaxSubArray(new[] { 1 }));
        Console.WriteLine(s.MaxSubArray(new[] { 5, 4, -1, 7, 8 }));
        /*
            SUM = 1
            SUM = 3
            SUM = 2
            SUM = 5
            SUM = 1
            SUM = 6 ==> MAX
            SUM = 5
            SUM = 3
            SUM = 4
        */
    }
}
