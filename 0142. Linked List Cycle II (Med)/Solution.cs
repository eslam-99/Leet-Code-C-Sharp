public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        HashSet<ListNode> nodes = new();
        while (head is not null)
            if (!nodes.Add(head)) return head;
            else head = head.next;
        return head!;
    }
}