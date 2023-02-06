internal partial class Program
{
    private static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine($"1 -> ( 1 ) {s.ClimbStairs(1)}");
        Console.WriteLine($"2 -> ( 2 ) {s.ClimbStairs(2)}");
        Console.WriteLine($"3 -> ( 3 ) {s.ClimbStairs(3)}");
        Console.WriteLine($"4 -> ( 5 ) {s.ClimbStairs(4)}");
        Console.WriteLine($"5 -> ( 8 ) {s.ClimbStairs(5)}");
        Console.WriteLine($"6 -> ( 13 ) {s.ClimbStairs(6)}");
        Console.WriteLine($"7 -> ( 21 ) {s.ClimbStairs(7)}");
        Console.WriteLine($"8 -> ( 34 ) {s.ClimbStairs(8)}");
        Console.WriteLine($"45 -> (  ) {s.ClimbStairs(45)}");
    }
}