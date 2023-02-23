public class Solution
{
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
    {
        // negative profit to sort descening
        // capital
        List<(int, int)> list = new();
        for (int i = 0; i < profits.Length; i++)
            list.Add((-profits[i], capital[i]));
        list.Sort();
        for (int i = 0; i < list.Count; i++)
        {
            int j = 0;
            foreach ((int, int) proj in list)
            {
                if (proj.Item2 <= w)
                {
                    w += -proj.Item1;
                    list.Remove(proj);
                    j--;
                    break;
                }
                j++;
            }
            if (j == list.Count) break;
        }

        return w;
    }
}