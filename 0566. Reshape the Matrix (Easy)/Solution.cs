public class Solution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        if (r == mat.Length || mat.Length * mat[0].Length != r * c) return mat;
        int[][] result = new int[r][];
        for (int i = 0; i < r; i++) result[i] = new int[c];
        for (int i = 0; i < mat.Length * mat[0].Length; i++)
            result[i / c][i % c] = mat[i / mat[0].Length][i % mat[0].Length];
        return result;
    }
}