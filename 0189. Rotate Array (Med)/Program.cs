using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new();
        
        int[] nums = new int[]{ 1, 2, 3, 4, 5, 6, 7 };
        s.Rotate(nums, 3);
        Console.WriteLine(string.Join(',', nums));
        
        nums = new int[]{ -1, -100, 3, 99 };
        s.Rotate(nums, 2);
        Console.WriteLine(string.Join(',', nums));

        nums = new int[]{ 1, 2, 3, 4, 5, 6 };
        s.Rotate(nums, 3);
        Console.WriteLine(string.Join(',', nums));
    }
}