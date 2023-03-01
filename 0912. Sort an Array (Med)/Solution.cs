public class Solution
{
    public int[] SortArray(int[] nums)
    {
        MergeSort(ref nums, 0, nums.Length - 1);
        return nums;
    }

    private void MergeSort(ref int[] nums, int l, int r)
    {
        if (l >= r) return;

        int mid = l + (r - l) / 2;
        MergeSort(ref nums, l, mid);
        MergeSort(ref nums, mid + 1, r);
        Merge(ref nums, l, r);
    }

    private void Merge(ref int[] nums, int l, int r)
    {
        int mid = l + (r - l) / 2;
        int[] result = new int[r - l + 1];
        int i = l, j = mid + 1, k = 0;
        while (i <= mid && j <= r)
            result[k++] = nums[i] < nums[j] ? nums[i++] : nums[j++];
        while (i <= mid) result[k++] = nums[i++];
        while (j <= r) result[k++] = nums[j++];
        for (k = 0; k < r - l + 1; k++) nums[l + k] = result[k];
    }
}