using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

public class Solution
{
    public int MaxAreaOfIsland(int[][] grid)
    {
        int maxArea = 0;
        var nextLand = GetNextLand(grid);
        while (nextLand != (-1, -1))
        {
            maxArea = Math.Max(maxArea, GetLandArea(ref grid, nextLand.Item1, nextLand.Item2));
            nextLand = GetNextLand(grid);
        }
        return maxArea;
    }

    private (int, int) GetNextLand(int[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
                if (grid[i][j] == 1) return (i, j);
        return (-1, -1);
    }

    private int GetLandArea(ref int[][] grid, int r, int c)
    {
        int area = 0;
        Queue<(int, int)> queue = new();
        queue.Enqueue((r, c));
        while (queue.Count > 0)
        {
            var cell = queue.Dequeue();
            if (grid[cell.Item1][cell.Item2] == -1) continue;
            if (cell.Item1 + 1 < grid.Length && grid[cell.Item1 + 1][cell.Item2] == 1)
                queue.Enqueue((cell.Item1 + 1, cell.Item2));
            if (cell.Item1 - 1 >= 0 && grid[cell.Item1 - 1][cell.Item2] == 1)
                queue.Enqueue((cell.Item1 - 1, cell.Item2));
            if (cell.Item2 + 1 < grid[0].Length && grid[cell.Item1][cell.Item2 + 1] == 1)
                queue.Enqueue((cell.Item1, cell.Item2 + 1));
            if (cell.Item2 - 1 >= 0 && grid[cell.Item1][cell.Item2 - 1] == 1)
                queue.Enqueue((cell.Item1, cell.Item2 - 1));
            grid[cell.Item1][cell.Item2] = -1;
            area++;
        }
        return area;
    }
}