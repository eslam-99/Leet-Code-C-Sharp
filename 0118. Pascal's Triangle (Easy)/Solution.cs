public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> rows = new List<IList<int>>() { new List<int>() { 1 } };
        for (int i = 1; i < numRows; i++)
        {
            IList<int> row = new List<int>();
            row.Add(1);
            for (int j = 1; j < i; j++) row.Add(rows[i - 1][j] + rows[i - 1][j - 1]);
            row.Add(1);
            rows.Add(row);
        }
        return rows;
    }
}