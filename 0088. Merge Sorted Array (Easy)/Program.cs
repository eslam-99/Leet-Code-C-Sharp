internal partial class Program
{
    private static void Main(string[] args)
    {
        Solution s = new Solution();
        int[] a = new int[] { 1, 2, 3, 0, 0, 0 };
        int[] b = new int[] { 2, 5, 6 };
        s.Merge(a, 3, b, 3);
        Console.WriteLine(string.Join(", ", a.Select(x => x.ToString()).ToArray()));
        a = new int[] { 0 };
        b = new int[] { 1 };
        s.Merge(a, 0, b, 1);
        Console.WriteLine(string.Join(", ", a.Select(x => x.ToString()).ToArray()));
        a = new int[] { 1 };
        b = new int[] { };
        s.Merge(a, 1, b, 0);
        Console.WriteLine(string.Join(", ", a.Select(x => x.ToString()).ToArray()));
        a = new int[] { 1, 2, 4, 5, 6, 0 };
        b = new int[] { 3 };
        s.Merge(a, 5, b, 1);
        Console.WriteLine(string.Join(", ", a.Select(x => x.ToString()).ToArray()));
        a = new int[] { 4, 5, 6, 0, 0, 0 };
        b = new int[] { 1, 2, 3 };
        s.Merge(a, 3, b, 3);
        Console.WriteLine(string.Join(", ", a.Select(x => x.ToString()).ToArray()));
    }
}