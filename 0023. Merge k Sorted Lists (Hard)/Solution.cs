public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0) return null!;
        ListNode head = new(), cur = head;
        HashSet<int> activeNodesIndexes = new();
        for (int i = 0; i < lists.Length; i++)
            if (lists[i] is not null) activeNodesIndexes.Add(i);
        while (activeNodesIndexes.Count > 0)
        {
            int minValIndex = activeNodesIndexes.First();
            foreach (int index in activeNodesIndexes)
                if (lists[index].val < lists[minValIndex].val) minValIndex = index;
            cur.next = lists[minValIndex];
            cur = cur.next;
            lists[minValIndex] = lists[minValIndex].next;
            if (lists[minValIndex] is null) activeNodesIndexes.Remove(minValIndex);
        }
        return head.next;
    }
}