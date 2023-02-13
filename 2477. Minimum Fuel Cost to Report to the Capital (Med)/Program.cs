internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        long res = s.MinimumFuelCost(new int[][]{
            new int[] { 0, 1 },
            new int[] { 0, 2 },
            new int[] { 0, 3 } },
        5);
        Console.WriteLine(res + " == 3");
        res = s.MinimumFuelCost(new int[][]{ 
            new int[] { 3 , 1 },
            new int[] { 3 , 2 },
            new int[] { 1 , 0 },
            new int[] { 0 , 4 },
            new int[] { 0 , 5 },
            new int[] { 4 , 6 }
        }, 2);
        Console.WriteLine(res + " == 7");
    }
}