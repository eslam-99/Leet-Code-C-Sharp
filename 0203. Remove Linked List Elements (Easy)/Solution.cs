public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        while (head is not null && head.val == val) head = head.next;
        if (head is null) return null!;
        ListNode h1 = head;
        while (h1.next is not null)
            if (h1.next.val == val) h1.next = h1.next.next;
            else h1 = h1.next;
        return head;
    }
}