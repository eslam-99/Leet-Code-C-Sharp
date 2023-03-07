public class Solution
{
    IList<IList<int>> memo;
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        return MinimumTotal_DP(triangle);
    }

    public int MinimumTotal_DP(IList<IList<int>> triangle)
    {
        memo = new List<IList<int>>() {
            new List<int>() { int.MaxValue, triangle[0][0], int.MaxValue }
        };
        int minPath = triangle[0][0];
        for (int level = 1; level < triangle.Count; level++)
        {
            memo.Add(new List<int>() { int.MaxValue });
            minPath = int.MaxValue;
            for (int i = 0; i < triangle[level].Count; i++)
            {
                memo[^1].Add(triangle[level][i] +
                    Math.Min(memo[level - 1][i], memo[level - 1][i + 1]));
                minPath = Math.Min(minPath, memo[^1][^1]);
            }
            memo[^1].Add(int.MaxValue);
        }

        return minPath;
    }

    public int MinimumTotal_Recursion(IList<IList<int>> triangle)
    {
        memo = new List<IList<int>>();
        foreach (var row in triangle)
            memo.Add(Enumerable.Repeat(int.MinValue, row.Count).ToList());

        return MinimumTotalPath(triangle, 0, 0);
    }

    private int MinimumTotalPath(IList<IList<int>> triangle, int level, int index)
    {
        if (level >= triangle.Count) return 0;
        if (memo[level][index] > int.MinValue) return memo[level][index];
        int result = triangle[level][index] +
            Math.Min(MinimumTotalPath(triangle, level + 1, index),
                MinimumTotalPath(triangle, level + 1, index + 1));
        memo[level][index] = result;
        return result;
    }
}