public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums.Length == 0) return null!;
        int c = (int)Math.Ceiling(((decimal)nums.Length - 1) / 2);
        TreeNode root = new(
            val: nums[c],
            left: SortedArrayToBST(nums[0..c]),
            right: SortedArrayToBST(nums[(c + 1)..nums.Length])
        );
        return root;
    }
}