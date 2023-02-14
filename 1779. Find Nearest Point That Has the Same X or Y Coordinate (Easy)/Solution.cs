public class Solution
{
    public int NearestValidPoint(int x, int y, int[][] points)
    {
        int minIndex = -1;
        for (int i = 0; i < points.Length; i++)
        {
            if (points[i][0] == x || points[i][1] == y)
            {
                minIndex = i;
                break;
            }
        }
        if (minIndex == -1) return minIndex;

        for (int i = minIndex + 1; i < points.Length; i++)
        {
            if (points[i][0] == x || points[i][1] == y)
            {
                if (Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]) < 
                    Math.Abs(x - points[minIndex][0]) + Math.Abs(y - points[minIndex][1]))
                    minIndex = i;
            }
        }

        return minIndex;
    }
}