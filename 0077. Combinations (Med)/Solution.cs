public class Solution
{
    private List<IList<int>> result = new();
    public IList<IList<int>> Combine(int n, int k)
    {
        Backtrack(new(), 1, n, k);
        return result;
    }
    private void Backtrack(List<int> nums, int next, int n, int k)
    {
        if (nums.Count == k)
        {
            result.Add(nums.ToList());
            return;
        }
        for (int i = next; i <= n; i++)
        {
            nums.Add(i);
            Backtrack(nums, i + 1, n, k);
            nums.RemoveAt(nums.Count - 1);
        }
    }
}