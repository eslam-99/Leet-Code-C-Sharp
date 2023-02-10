public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        return GetIntersectionNode_V2(headA, headB);
    }
    public ListNode GetIntersectionNode_V1(ListNode headA, ListNode headB)
    {
        int lenA = 0, lenB = 0;
        ListNode a = headA, b = headB;
        while (a is not null) { lenA++; a = a.next; }
        while (b is not null) { lenB++; b = b.next; }
        while (lenA > lenB) { lenA--; headA = headA.next; }
        while (lenA < lenB) { lenB--; headB = headB.next; }
        while (headA is not null && headB is not null)
        {
            if (headA == headB) return headA;
            headA = headA.next;
            headB = headB.next;
        }
        return null!;
    }
    public ListNode GetIntersectionNode_V2(ListNode headA, ListNode headB)
    {
        HashSet<ListNode> visited = new();
        while (headA is not null)
        {
            visited.Add(headA);
            headA = headA.next;
        }
        while (headB is not null)
        {
            if (visited.Contains(headB)) return headB;
            headB = headB.next;
        }
        return null!;
    }
}