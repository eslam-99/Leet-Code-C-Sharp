public class Solution
{
    public int ShipWithinDays(int[] weights, int days)
    {
        int maxLoad = -1, totalWeight = 0;
        foreach (int w in weights)
        {
            totalWeight += w;
            maxLoad = Math.Max(maxLoad, w);
        }

        int left = maxLoad, right = totalWeight;
        while (left < right)
        {
            int mid = (left + right) / 2;
            if (IsFeasible(weights, mid, days)) right = mid;
            else left = mid + 1;
        }
        return left;
    }

    private bool IsFeasible(int[] weights, int capacity, int days)
    {
        int currentDays = 1, currentCapacity = 0;
        foreach (int w in weights)
        {
            currentCapacity += w;
            if (currentCapacity > capacity)
            {
                currentCapacity = w;
                currentDays++;
            }
            if (currentDays > days) return false;
        }
        return currentDays <= days;
    }
}