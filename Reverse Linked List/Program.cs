using System;

namespace Reverse_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(3);
            l1.next.next.next = new ListNode(4);
            l1.next.next.next.next = new ListNode(5);
            Console.WriteLine(ReverseList(l1));
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode root = ReverseList(head.next);

            head.next.next = head;
            head.next = null;

            return root;
        }
    }


}
