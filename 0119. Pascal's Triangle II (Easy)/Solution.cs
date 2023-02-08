public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        IList<int> row = new List<int>() { 1 };
        for (int i = 1; i <= rowIndex; i++)
        {
            IList<int> tempRow = new List<int>();
            tempRow.Add(1);
            for (int j = 1; j < i; j++) tempRow.Add(row[j] + row[j - 1]);
            tempRow.Add(1);
            row = tempRow;
        }
        return row;
    }
}