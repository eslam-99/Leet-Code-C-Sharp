public class Solution
{
    public long MinimumTime(int[] time, int totalTrips)
    {
        if (time.Length == 1) return (long)totalTrips * (long)time[0];
        long maxTime = totalTrips * time.Max();
        if (maxTime / totalTrips != time.Max()) maxTime = long.MaxValue >> 5; // to avoid overflow everywhere
        long left = 1, right = maxTime;
        while (left < right)
        {
            long mid = left + (right - left) / 2;
            long currentTrips = 0;
            foreach (var bus in time)
                currentTrips += mid / bus;
            if (currentTrips >= totalTrips) right = mid;
            else left = mid + 1;
        }
        return left;
    }
}