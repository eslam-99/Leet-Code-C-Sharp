public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        if (head is null) return null!;
        ListNode slow = head, fast = head;
        while (fast.next is not null)
        {
            fast = fast.next;
            slow = slow.next;
            if (fast.next is not null) fast = fast.next;
        }
        return slow;
    }
}