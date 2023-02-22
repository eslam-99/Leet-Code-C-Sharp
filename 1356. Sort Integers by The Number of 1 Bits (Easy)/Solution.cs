using System.Numerics;

public class Solution
{
    public int[] SortByBits(int[] arr)
    {
        return SortByBits_V2(arr);
    }
    public int[] SortByBits_V1(int[] arr)
    {
        SortedList<int, List<int>> numbers = new();
        int[] result = new int[arr.Length];
        foreach (int n in arr)
        {
            int c = BitOperations.PopCount((uint)n);
            if (numbers.ContainsKey(c)) numbers[c].Add(n);
            else numbers[c] = new() { n };
        }
        int i = 0;
        foreach (var pair in numbers)
        {
            pair.Value.Sort();
            foreach (int n in pair.Value) result[i++] = n;
        }

        return result;
    }
    public int[] SortByBits_V2(int[] arr)
    {
        return arr.OrderBy(x => (BitOperations.PopCount((uint)x), x)).ToArray();
    }
}