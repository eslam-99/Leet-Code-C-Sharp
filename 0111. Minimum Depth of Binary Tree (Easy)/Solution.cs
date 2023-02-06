public class Solution
{
    public int MinDepth(TreeNode root)
    {
        if (root == null) return 0;
        int left = MinDepth(root.left);
        int right = MinDepth(root.right);
        if (left == 0 || right == 0) return 1 + Math.Max(left, right);
        return 1 + Math.Min(left, right);
    }
}
