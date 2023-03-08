public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        if (piles.Length == h) return piles.Max();
        int left = 1, right = piles.Max();
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            int c = 0;
            foreach (int p in piles)
                c += Math.Max((int)Math.Ceiling((decimal)p / mid), 1);
            if (c <= h) right = mid;
            else left = mid + 1;
        }
        return left;
    }
}