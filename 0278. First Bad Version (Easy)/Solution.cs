public class Solution : VersionControl
{
    public Solution(int firstBadVersion) : base(firstBadVersion) { }

    public int FirstBadVersion(int n)
    {
        int left = 1, right = n;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (IsBadVersion(mid))
            {
                if (IsBadVersion(mid - 1)) right = mid;
                else return mid;
            }
            else left = mid + 1;
        }
        return left;
    }
}
