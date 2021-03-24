using System;

namespace _0141._Linked_List_Cycle__Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(3);
            node.next = new ListNode(2);
            node.next.next = new ListNode(0);
            node.next.next.next = new ListNode(-4);
            Console.WriteLine(HasCycle(node));
        }

        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;

            ListNode fast = head;
            ListNode slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow) return true;
            }

            return false;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
    }
}
