internal partial class Program
{ 
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            return MergeTwoLists_v3(list1, list2);
        }
        public ListNode MergeTwoLists_v1(ListNode list1, ListNode list2)
        {
            ListNode newList = null;
            ListNode current = null;
            if (list1 is not null && list2 is not null)
            {
                if (list1.val < list2.val)
                {
                    newList = list1;
                    list1 = list1.next;
                }
                else
                {
                    newList = list2;
                    list2 = list2.next;
                }
            }
            else if (list1 is not null)
            {
                newList = list1;
                list1 = list1.next;
            }
            else if (list2 is not null)
            {
                newList = list2;
                list2 = list2.next;
            }

            if (newList is null) return null;
            current = newList;

            while (true)
            {
                if (list1 is not null && list2 is not null)
                {
                    if (list1.val < list2.val)
                    {
                        current.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        current.next = list2;
                        list2 = list2.next;
                    }
                }
                else if (list1 is not null)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else if (list2 is not null)
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                else break;
                current = current.next;
            }
            return newList;
        }
        public ListNode MergeTwoLists_v2(ListNode list1, ListNode list2)
        {
            ListNode newList = null;
            ListNode current = null;

            if (list1 is not null || list2 is not null)
            {
                if ((list1?.val ?? 1000) < (list2?.val ?? 1000))
                    { newList = list1; list1 = list1.next; }
                else { newList = list2; list2 = list2.next; }
            }

            if (newList is null) return null;
            current = newList;

            while (true)
            {
                if (list1 is not null || list2 is not null)
                {
                    if ((list1?.val ?? 1000) < (list2?.val ?? 1000))
                        { current.next = list1; list1 = list1.next; }
                    else { current.next = list2; list2 = list2.next; }
                    current = current.next;
                }
                else break;
            }

            return newList;
        }
        public ListNode MergeTwoLists_v3(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            if (list1.val <= list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }
    }
}