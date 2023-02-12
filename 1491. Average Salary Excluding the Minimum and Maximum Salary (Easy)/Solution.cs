public class Solution
{
    public double Average(int[] salary)
    {
        int min = salary[0], max = salary[0], sum = salary[0];
        for (int i = 1; i < salary.Length; i++)
        {
            min = Math.Min(min, salary[i]);
            max = Math.Max(max, salary[i]);
            sum += salary[i];
        }
        return (double)(sum - min - max) / (salary.Length - 2);
    }
}