public class Program
{
    private static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine(s.SearchInsert(new[] {1,3,4,5,6}, 2));
        Console.WriteLine(s.SearchInsert(new[] {1,3,5,6}, 2));
        Console.WriteLine(s.SearchInsert(new[] {2,3,4,5,6}, 1));
    }
}