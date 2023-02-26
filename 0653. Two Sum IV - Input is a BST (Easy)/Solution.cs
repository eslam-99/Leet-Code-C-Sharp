public class Solution
{
    public bool FindTarget(TreeNode root, int k)
    {
        if (root is null) return false;
        List<int> nums = new();
        Stack<TreeNode> stack = new();
        // Inorder Traversal
        while (root is not null || stack.Count > 0)
        {
            while (root is not null)
            {
                stack.Push(root);
                root = root.left;
            }
            root = stack.Pop();
            nums.Add(root.val);
            root = root.right;
        }
        // Search for sum == k
        int left = 0, right = nums.Count - 1;
        while (left < right)
        {
            if (nums[left] > k - nums[right]) right--;
            else if (nums[left] < k - nums[right]) left++;
            else return true;
        }
        return false;
    }
}