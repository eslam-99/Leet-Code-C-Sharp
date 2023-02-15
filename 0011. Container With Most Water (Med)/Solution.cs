public class Solution
{
    public int MaxArea(int[] heights)
    {
        int maxArea = 0;
        int lower = 0, upper = heights.Length - 1;
        while (lower < upper)
        {
            maxArea = Math.Max(maxArea, Math.Min(heights[lower], heights[upper]) * (upper - lower));
            if (heights[lower] > heights[upper]) upper--;
            else lower++;
        }
        return maxArea;
    }
}