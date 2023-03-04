public class Solution
{
    private readonly int[] DIR = new int[] { 0, 1, 0, -1 , 0};
    public int OrangesRotting(int[][] grid)
    {
        int minMinutes = 0, m = grid.Length, n = grid[0].Length, fresh = 0;
        Queue<(int, int, int)> q = new();

        for (int r = 0; r < m; r++)
            for (int c = 0; c < n; c++)
                if (grid[r][c] == 2) q.Enqueue((r, c, minMinutes));
                else if (grid[r][c] == 1) fresh++;

        while (q.Count > 0)
        {
            (int r, int c, int minutes) = q.Dequeue();
            for (int i = 0; i < 4; i++)
            {
                int nr = r + DIR[i], nc = c + DIR[i + 1];
                if (nr >= m || nr < 0 || nc >= n || nc < 0) continue;
                if (grid[nr][nc] == 1) q.Enqueue((nr, nc, minutes + 1));
            }
            if (grid[r][c] == 2) continue;
            grid[r][c] = 2;
            minMinutes = Math.Max(minMinutes, minutes);
            fresh--;
        }

        return fresh == 0 ? minMinutes : -1;
    }
}