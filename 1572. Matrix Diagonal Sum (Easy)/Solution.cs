public class Solution
{
    public int DiagonalSum(int[][] mat)
    {
        int sum = 0;
        for (int i = 0; i < (mat.Length + 1) / 2; i++)
        {
            if (i == (mat[0].Length + 1) / 2 - 1 && mat[0].Length % 2 == 1) sum += mat[i][i];
            else sum += mat[i][i] + mat[^(i + 1)][^(i + 1)] + mat[^(i + 1)][i] + mat[i][^(i + 1)];
        }
        return sum;
    }
}