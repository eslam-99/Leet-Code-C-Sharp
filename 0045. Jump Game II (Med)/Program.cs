﻿internal class Program
{
    private static void Main(string[] args)
    {
        Solution s = new Solution();
        Console.WriteLine("Expected: 1, Found: " + s.Jump(new[] { 2, 1 }));
        Console.WriteLine("Expected: 2, Found: " + s.Jump(new[] { 1, 2, 3 }));
        Console.WriteLine("Expected: 2, Found: " + s.Jump(new[] { 2, 3, 0, 1, 4 }));
        Console.WriteLine("Expected: 2, Found: " + s.Jump(new[] { 2, 3, 1, 1, 4 }));
        Console.WriteLine("Expected: 3, Found: " + s.Jump(new[] { 5, 9, 3, 2, 1, 0, 2, 3, 3, 1, 0, 0 }));
        Console.WriteLine("Expected: 2, Found: " + s.Jump(new[] { 9, 7, 9, 4, 8, 1, 6, 1, 5, 6, 2, 1, 7, 9, 0 }));
        Console.WriteLine("Expected: ?, Found: " + s.Jump(new[] { 5, 6, 4, 4, 6, 9, 4, 4, 7, 4, 4, 8, 2, 6, 8, 1, 5, 9, 6,
            5, 2, 7, 9, 7, 9, 6, 9, 4, 1, 6, 8, 8, 4, 4, 2, 0, 3, 8, 5 }));
        Console.WriteLine("Expected: ?, Found: " + s.Jump(new[] { 5, 8, 1, 8, 9, 8, 7, 1, 7, 5, 8, 6, 5, 4, 7, 3, 9, 9, 0,
            6, 6, 3, 4, 8, 0, 5, 8, 9, 5, 3, 7, 2, 1, 8, 2, 3, 8, 9, 4, 7, 6, 2, 5, 2, 8, 2, 7, 9,
            3, 7, 6, 9, 2, 0, 8, 2, 7, 8, 4, 4, 1, 1, 6, 4, 1, 0, 7, 2, 0, 3, 9, 8, 7, 7, 0, 6, 9,
            9, 7, 3, 6, 3, 4, 8, 6, 4, 3, 3, 2, 7, 8, 5, 8, 6, 0 }));
    }
}