public class Solution
{
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if (root is null) return new TreeNode(val);
        TreeNode ptr = root;
        while (true)
        {

            if (ptr.val > val)
            {
                if (ptr.left is null)
                {
                    ptr.left = new(val);
                    break;
                }
                else ptr = ptr.left;
            }
            else
            {
                if (ptr.right is null)
                {
                    ptr.right = new(val);
                    break;
                }
                else ptr = ptr.right;
            }
        }
        return root;
    }
}