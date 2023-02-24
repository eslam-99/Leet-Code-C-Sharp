public class Solution
{
    public int MinimumDeviation(int[] nums)
    {
        PriorityQueue<int, int> pq = new(Comparer<int>.Create((x, y) => y - x));
        int minValue = int.MaxValue, minDiviation = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 1) nums[i] <<= 1;
            pq.Enqueue(nums[i], nums[i]);
            minValue = Math.Min(minValue, nums[i]);
        }

        while (true)
        {
            int maxValue = pq.Dequeue();
            minDiviation = Math.Min(minDiviation, maxValue - minValue);
            if (maxValue % 2 == 1) break;
            maxValue >>= 1;
            minValue = Math.Min(minValue, maxValue);
            pq.Enqueue(maxValue, maxValue);
        }

        return minDiviation;
    }
}