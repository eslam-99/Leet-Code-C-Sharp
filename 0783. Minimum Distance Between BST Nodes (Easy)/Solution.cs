class Solution
{
    int minDifference = int.MaxValue;
    TreeNode? prevValue;

    void InorderTraversal(TreeNode root)
    {
        if (root == null) return;
        InorderTraversal(root.left);
        if (prevValue != null)
            minDifference = Math.Min(minDifference, root.val - prevValue.val);
        prevValue = root;
        InorderTraversal(root.right);
    }

    public int MinDiffInBST(TreeNode root)
    {
        InorderTraversal(root);
        return minDifference;
    }
}