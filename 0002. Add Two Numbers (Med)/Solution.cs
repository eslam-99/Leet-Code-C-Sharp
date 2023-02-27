public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode root = new(), iter = root;
        bool overflow = false;
        while (l1 is not null || l2 is not null || overflow)
        {
            int sum = 0;
            if (l1 is not null) { sum += l1.val; l1 = l1.next; }
            if (l2 is not null) { sum += l2.val; l2 = l2.next; }
            if (overflow) sum++;
            overflow = false;
            if (sum > 9)
            {
                sum %= 10;
                overflow = true;
            }
            iter.next = new(sum);
            iter = iter.next;
        }
        return root.next;
    }
}