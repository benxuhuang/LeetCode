using System;

namespace _203._Remove_Linked_List_Elements_Easy_
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(3);
            l1.next.next = new ListNode(6);
            l1.next.next.next = new ListNode(4);

            Console.WriteLine(RemoveElements(l1,6));
        }

        public static ListNode RemoveElements(ListNode head, int val)
        {
            ListNode tempHeadNode = new ListNode(0);

            tempHeadNode.next = head;

            ListNode current = tempHeadNode;

            while(current.next != null)
            {
                if (current.next.val == val)
                {
                    current.next = current.next.next;
                } else
                {
                    current = current.next;
                }
            }

            return tempHeadNode.next;
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
    }
}
