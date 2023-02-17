internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        Console.WriteLine(s.SumOddLengthSubarrays(new int[] { 1, 4, 2, 5, 3 }));
        Console.WriteLine(s.SumOddLengthSubarrays(new int[] { 1, 1, 1, 1, 1, 1, 1 }));
        Console.WriteLine(s.SumOddLengthSubarrays(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        Console.WriteLine(s.SumOddLengthSubarrays(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
    }
}
