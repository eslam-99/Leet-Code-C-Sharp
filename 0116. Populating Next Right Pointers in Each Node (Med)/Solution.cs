public class Solution
{
    public Node Connect(Node root)
    {
        int level = 0;
        Stack<(Node, int)> s = new();
        List<Node> list = new();
        Node current = root;
        while (current is not null || s.Count > 0)
        {
            while (current is not null)
            {
                s.Push((current, level));
                if (list.Count > level)
                {
                    list[level].next = current;
                    list[level] = current;
                }
                else list.Add(current);
                level++;
                current = current.left;
            }

            (current, level) = s.Pop();
            current = current.right;
            level++;
        }
        return root;
    }
}