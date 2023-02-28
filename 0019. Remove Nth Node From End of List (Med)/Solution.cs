public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode slow = head, fast = head;
        while (n-- > 0) fast = fast.next;
        while (fast is not null && fast.next is not null)
        {
            slow = slow.next;
            fast = fast.next;
        }
        if (fast is null) return head.next;
        slow.next = slow.next.next;
        return head;
    }
}