public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head is null || head.next is null) return head!;
        ListNode next = null!;
        while (head is not null) (head, next, head.next) = (head.next, head, next);
        return next;
    }
}