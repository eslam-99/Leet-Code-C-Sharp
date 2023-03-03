public class Solution
{
    public Node Connect(Node root)
    {
        return Connect_V2(root);
    }
    public Node Connect_V1(Node root)
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
    public Node Connect_V2(Node root)
    {
        if (root == null) return null!;
        if (root.left == null) return root;

        root.left.next = root.right;
        root.right.next = (root.next is null ? null! : root.next.left);
        Connect(root.left);
        Connect(root.right);
        
        return root;
    }
}