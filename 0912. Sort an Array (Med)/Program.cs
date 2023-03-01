internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(string.Join(',', s.SortArray(new int[] { 5, 2, 3, 1 })));
    }
}