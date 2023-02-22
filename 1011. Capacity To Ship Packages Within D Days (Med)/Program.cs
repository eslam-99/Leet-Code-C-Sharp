internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        Console.WriteLine(s.ShipWithinDays(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5) + " : 15");
        Console.WriteLine(s.ShipWithinDays(new int[] { 3, 2, 2, 4, 1, 4 }, 3) + " : 6");
        Console.WriteLine(s.ShipWithinDays(new int[] { 1, 2, 3, 1, 1 }, 4) + " : 3");
        Console.WriteLine(s.ShipWithinDays(new int[] { 2, 2, 3, 4, 4, 5 }, 2) + " : 11");
    }
}