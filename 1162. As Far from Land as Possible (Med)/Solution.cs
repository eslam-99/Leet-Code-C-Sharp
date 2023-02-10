public class Solution
{
    private struct Pair<T1, T2> { public T1 x; public T2 y; }
    public int MaxDistance(int[][] grid)
    {
        int distance = -1;
        Queue<Pair<int, int>> queue = new();
        do
        {
            while (queue.Count != 0)
            {
                var p = queue.Dequeue();
                grid[p.x][p.y] = 1;
            }
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        if (i > 0 && grid[i - 1][j] == 0) queue.Enqueue(new() { x = i - 1, y = j });
                        if (i + 1 < grid.Length && grid[i + 1][j] == 0) queue.Enqueue(new() { x = i + 1, y = j });
                        if (j > 0 && grid[i][j - 1] == 0) queue.Enqueue(new() { x = i, y = j - 1 });
                        if (j + 1 < grid[i].Length && grid[i][j + 1] == 0) queue.Enqueue(new() { x = i, y = j + 1 });
                    }
                }
            }
            distance++;
        } while (queue.Count != 0);
        return distance == 0 ? -1 : distance;
    }
}