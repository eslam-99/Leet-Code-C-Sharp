public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        if (root == null) return true;
        return Math.Abs(MaxDepth(root.left) - MaxDepth(root.right)) < 2 && IsBalanced(root.left) && IsBalanced(root.right);
    }
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }

}