using System;

namespace _0083._Remove_Duplicates_from_Sorted_List__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(2);
            l1.next.next.next = new ListNode(2);
            l1.next.next.next.next = new ListNode(3);
            l1.next.next.next.next.next = new ListNode(4);

            var result = DeleteDuplicates(l1);
        }

        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode curr = head;

            while (curr.next != null)
            {
                if (curr.val == curr.next.val)
                    curr.next = curr.next.next;
                else
                    curr = curr.next;
            }

            return head;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
