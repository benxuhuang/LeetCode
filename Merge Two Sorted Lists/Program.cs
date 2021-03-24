using System;

namespace Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            var result = MergeTwoLists(l1, l2);
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
