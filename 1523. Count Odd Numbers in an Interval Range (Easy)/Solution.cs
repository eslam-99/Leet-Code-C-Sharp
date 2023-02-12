public class Solution
{
    public int CountOdds(int low, int high)
    {
        if (low == high) return low % 2;
        return (high - 1) / 2 - low / 2 + 1;
    }
} 