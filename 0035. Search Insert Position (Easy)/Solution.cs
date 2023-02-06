using System;

internal partial class Program
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int foundPos = Array.BinarySearch(nums, target);
            if (foundPos < 0) return ~foundPos;
            return foundPos;
        }
    }
}