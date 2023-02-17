public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int rows = matrix.Length, cols = matrix[0].Length;
        int len = rows * cols;
        int left = 0, right = len - 1;
        int current = (right + left) >> 1;
        while (left <= right)
        {
            int row = current / cols, col = current % cols;
            if (matrix[row][col] == target) return true;
            else if (matrix[row][col] > target) right = current - 1;
            else left = current + 1;
            current = (right + left) >> 1;
        }
        return false;
    }
}