public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        if (root is null) return true;

        return Isbst(root, long.MinValue, long.MaxValue);
    }

    bool Isbst(TreeNode root, long min, long max)
    {
        if (root is null) return true;

        if (root.val > min && root.val < max)
            return Isbst(root.left, min, root.val)
                && Isbst(root.right, root.val, max);

        return false;
    }
}