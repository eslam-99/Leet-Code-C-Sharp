public class Solution
{
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        List<int> result = new();
        int plus = 0;
        int index = num.Length - 1;
        while (index >= 0 || k > 0)
        {
            int toAdd = k % 10 + plus;
            if (index > 0) toAdd += num[index];
            result.Add(toAdd);
            plus = result[0] / 10;
            result[0] %= 10;
            k /= 10;
        }
        if (plus == 1) result.Add(1);
        result.Reverse();
        return result;
    }
}