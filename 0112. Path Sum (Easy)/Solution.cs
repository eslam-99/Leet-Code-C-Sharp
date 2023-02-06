public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        return HasPathSum(root, 0, targetSum);
    }
    public bool HasPathSum(TreeNode root, int sum, int targetSum)
    {
        if (root == null) return false;
        bool isEqualSum = sum + root.val == targetSum && root.left is null && root.right is null;
        return isEqualSum || HasPathSum(root.left!, sum + root.val, targetSum) || HasPathSum(root.right!, sum + root.val, targetSum);
    }
}