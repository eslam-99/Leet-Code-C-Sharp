public class Solution
{
    public bool CheckStraightLine(int[][] coordinates)
    {
        // Slope : (y - y1) / (x - x1) = (y1 - y0) / (x1 - x0)
        // Then Slope : (x1 - x0) * (y - y1) = (x - x1) * (y1 - y0)
        int[] p0 = coordinates[0], p1 = coordinates[1];
        return coordinates.All(p => (p1[1] - p0[1]) * (p[0] - p1[0]) == (p[1] - p1[1]) * (p1[0] - p0[0]));
    }
}