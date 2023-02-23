public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        if (root is null) return new List<IList<int>>();
        return new List<IList<int>>() { new List<int> { root.val } }.Concat(BFS(root)).ToList();
    }

    private List<List<int>> BFS(TreeNode root)
    {
        if (root == null) return null!;
        List<List<int>> result = new();
        List<List<int>> leftTree = new();
        List<List<int>> rightTree = new();
        List<int> children = new();
        if (root.left is not null)
        {
            children.Add(root.left.val);
            leftTree = BFS(root.left);
        }
        if (root.right is not null)
        {
            children.Add(root.right.val);
            rightTree = BFS(root.right);
        }
        if (children.Count > 0) result.Add(children);
        if (leftTree.Count > 0 && rightTree.Count > 0)
        {
            for (int i = 0; i < Math.Max(leftTree.Count, rightTree.Count); i++)
            {
                if (i < leftTree.Count && i < rightTree.Count)
                {
                    result.Add(leftTree[i].Concat(rightTree[i]).ToList());
                }
                else if (i < leftTree.Count) result.Add(leftTree[i]);
                else if (i < rightTree.Count) result.Add(rightTree[i]);
            }
        }
        else if (leftTree.Count > 0)
            for (int i = 0; i < leftTree.Count; i++) result.Add(leftTree[i]);
        else if (rightTree.Count > 0)
            for (int i = 0; i < rightTree.Count; i++) result.Add(rightTree[i]);

        return result;
    }
}