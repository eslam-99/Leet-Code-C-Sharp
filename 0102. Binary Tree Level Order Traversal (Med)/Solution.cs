public class Solution
{
    private List<IList<int>> levels = new List<IList<int>>();
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        if (root == null) return levels;
        BFS(root, 0);
        return levels;
    }

    public void BFS(TreeNode node, int level)
    {
        if (levels.Count == level) levels.Add(new List<int>());

        levels[level].Add(node.val);

        if (node.left != null) BFS(node.left, level + 1);
        if (node.right != null) BFS(node.right, level + 1);
    }
}