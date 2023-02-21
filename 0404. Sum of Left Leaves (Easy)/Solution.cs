public class Solution
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        if (root is null) return 0;
        return SumOfLeftLeaves(root.left) + SumOfLeftLeaves(root.right) +
            (root.left is not null && root.left.left is null && root.left.right is null
            ? root.left.val : 0);
    }
}