public class Solution
{
    public int ArraySign(int[] nums)
    {
        int prod = 1;
        foreach (var n in nums) prod *= n.CompareTo(0);
        return prod;
    }
}