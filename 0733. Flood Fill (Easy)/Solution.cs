public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int oldColor = image[sr][sc];
        if (oldColor == color) return image;
        Queue<(int, int)> queue = new();
        queue.Enqueue((sr, sc));
        while (queue.Count > 0)
        {
            var cell = queue.Dequeue();
            if (cell.Item1 + 1 < image.Length && image[cell.Item1 + 1][cell.Item2] == oldColor)
                queue.Enqueue((cell.Item1 + 1, cell.Item2));
            if (cell.Item1 - 1 >= 0 && image[cell.Item1 - 1][cell.Item2] == oldColor)
                queue.Enqueue((cell.Item1 - 1, cell.Item2));
            if (cell.Item2 + 1 < image[0].Length && image[cell.Item1][cell.Item2 + 1] == oldColor)
                queue.Enqueue((cell.Item1, cell.Item2 + 1));
            if (cell.Item2 - 1 >= 0 && image[cell.Item1][cell.Item2 - 1] == oldColor)
                queue.Enqueue((cell.Item1, cell.Item2 - 1));
            image[cell.Item1][cell.Item2] = color;
        }
        return image;
    }
}